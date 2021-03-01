using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class MasterSchedule_ViewModel : Models.MasterSchedule_Workbook_Model
    {
        public MasterSchedule_ViewModel() { }
        public MasterSchedule_ViewModel(XElement ms_el)
        {
            LoadFromXElement(ms_el);
        }

        private void LoadFromXElement(XElement ms_el)
        {
            try
            {
                if (ms_el == null) return;

                if (!string.IsNullOrEmpty(ms_el.Attribute("checkSum")?.Value))
                    this.Checksum = ms_el.Attribute("checkSum")?.Value;

                var section_els = ms_el.Element("sections")?.Elements("section");
                if (section_els == null || section_els.Count() == 0) return;
                foreach (XElement section_el in section_els)
                {
                    var section = new Section_Model(section_el);
                    if (section != null)
                        this.Sections.Add(section);
                }
                MasterSchedule_FullPath = Properties.Settings.Default.MasterScheduleFullPath;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        public string Checksum { get; set; }
        public string MasterSchedule_FullPath { get; internal set; }

        public void LoadFromFile()
        { 
            try
            {
                var full_path = new FilePath_Helper().MasterScheduleFile_FullPath();
                if (!File.Exists(full_path)) return;
                var doc = XDocument.Load(full_path);
                if (doc == null) return;
                LoadFromXElement(doc.Element("masterSchedule"));
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        public void WriteToFile(IWriter writer)
        {
            try
            {
                writer.SaveToFile();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return;
            }
        }
    }
}
