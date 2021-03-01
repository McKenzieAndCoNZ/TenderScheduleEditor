using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class Save_MasterSchedule_Helper : IWriter
    {
        private ViewModels.MasterSchedule_ViewModel _master_schedule_data;

        public Save_MasterSchedule_Helper(ViewModels.MasterSchedule_ViewModel master_schedule_data)
        {
            this._master_schedule_data = master_schedule_data;
        }

        bool IWriter.SaveToFile()
        {
            try
            {
                XDocument doc = null;
                if (!File.Exists(_master_schedule_data.MasterSchedule_FullPath))
                {
                    doc = CreateNewProjectFile(_master_schedule_data);
                }
                else
                    doc = XDocument.Load(_master_schedule_data.MasterSchedule_FullPath);

                if (!string.IsNullOrEmpty(_master_schedule_data.Checksum))
                    doc.Element("masterSchedule").Attribute("checkSum").Value = _master_schedule_data.Checksum;

                // save sections
                 bool results = SaveSeparablePortions(_master_schedule_data.Sections, ref doc);

                if (results)
                {
                    var full_path = _master_schedule_data.MasterSchedule_FullPath;
                    if (string.IsNullOrEmpty(full_path) || !File.Exists(full_path))
                    {
                        full_path = new FilePath_Helper().MasterSchedule_DirPath() + "\\MasterSchedule" + Properties.Settings.Default.MasterScheduleFileType;
                        _master_schedule_data.MasterSchedule_FullPath = full_path;
                    }
                    doc.Save(full_path);
                } 
                return results;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        } 

        private XDocument CreateNewProjectFile(ViewModels.MasterSchedule_ViewModel template_data)
        {
            try
            {
                var doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
                            new XElement("masterSchedule",
                                new XAttribute("checkSum", template_data.Checksum),
                            new XElement("sections")));

                return doc;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private bool SaveSeparablePortions(List<Section_Model> sections, ref XDocument doc)
        {
            try
            {
                var sections_el = doc.Element("masterSchedule").Element("sections");
                sections_el.RemoveAll();

                foreach (var section in sections)
                {
                    var section_el = new XElement("section",
                        new XAttribute("id", section.Id),
                        new XAttribute("name", section.Section_Name),
                        new XAttribute("number", section.Section_Number));
                    sections_el.Add(section_el);

                    foreach (var item in section.Items)
                    {
                        var item_el = new XElement("item",
                                new XAttribute("masterScheduleId", item.Id),
                            new XElement("item_number", item.ItemNumber),
                            new XElement("subItem", item.SubItem),
                            new XElement("details", item.Details),
                            new XElement("unit", item.Unit),
                            new XElement("qty", item.Quantity),
                            new XElement("comment", item.Comment));
                        section_el.Add(item_el);
                    }
                    if (section.Children.Count > 0)
                    {
                        var sub_sections_el = new XElement("subSections",
                        new XAttribute("id", Guid.NewGuid().ToString("N")));
                        section_el.Add(sub_sections_el);

                        foreach (var child_section in section.Children)
                        {
                            var sub_section_el = new XElement("subSection",
                            new XAttribute("id", child_section.Id),
                            new XAttribute("name", child_section.SubItem),
                            new XAttribute("number", section.Section_Number));
                            sub_sections_el.Add(sub_section_el);

                            foreach (var item in child_section.Children)
                            {
                                var item_el = new XElement("item",
                                        new XAttribute("masterScheduleId", item.Id),
                                    new XElement("item_number", item.ItemNumber),
                                    new XElement("subItem", item.SubItem),
                                    new XElement("details", item.Details),
                                    new XElement("unit", item.Unit),
                                    new XElement("qty", item.Quantity),
                                    new XElement("comment", item.Comment));
                                sub_section_el.Add(item_el);
                            }
                        }
                    }    
                }

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

    }
}
