using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class Save_ProjectFile_Helper:IWriter
    {
        private ProjectFile_ViewModel _proj_data;

        public Save_ProjectFile_Helper(ProjectFile_ViewModel proj_data)
        {
            this._proj_data = proj_data;
        }

        bool IWriter.SaveToFile()
        { 
            try
            { 
                XDocument doc = null;
                if (!File.Exists(_proj_data.Project_FullPath))
                {
                    doc = CreateNewProjectFile(_proj_data);
                }
                else
                    doc = XDocument.Load(_proj_data.Project_FullPath);

                bool results = SaveProjectAttributes(_proj_data, ref doc);

                if (results == false)
                    return false;

                // save contract info
                results = SaveContractInfo(_proj_data.Contract_Information, ref doc);

                if (results == false)
                    return false;

                // save sections
                var sep_portions_el = doc.Root.Element("separablePortions");
                results = SaveSeparablePortions(_proj_data, ref sep_portions_el);

                if (results)
                    doc.Save(_proj_data.Project_FullPath);

                    return results;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        private bool SaveProjectAttributes(ProjectFile_ViewModel proj_data, ref XDocument doc)
        {
            try
            {
                if (proj_data == null) return true;

                //========Status=============================================
                XAttribute attrStatus = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.Status);
                if (attrStatus == null)
                {
                    attrStatus =new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.Status,proj_data.Status);
                }
                attrStatus.Value = proj_data.Status;

                //========Tag=============================================
                XAttribute attrTag = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.Tag);
                if (attrTag == null)
                {
                    attrTag = new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.Tag, "");
                }
                string tag = "";
                foreach (var item in proj_data.Tags)
                {
                    tag += item;
                    if (item != proj_data.Tags[proj_data.Tags.Count - 1])
                        tag += ";";
                }
                attrTag.Value = tag;

                //========Comments=============================================
                XAttribute attrComments = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.Comments);
                if (attrComments == null)
                {
                    attrComments = new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.Comments, "");
                }
                attrComments.Value = proj_data.Comments;

                //=======LastEditedBy============================================== 
                XAttribute attrLastEditBy = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.LastEditedBy);
                if (attrLastEditBy == null)
                {
                    attrLastEditBy = new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.LastEditedBy, 
                                                    proj_data.LastEditedBy);
                }
                attrLastEditBy.Value = proj_data.LastEditedBy;

                //=======showInRecentList============================================== 
                XAttribute attrshowInRecentList = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.ShowInRecentList);
                if (attrshowInRecentList == null)
                {
                    attrshowInRecentList = new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.LastEditedBy,
                        proj_data.LastEditedBy);
                }
                attrshowInRecentList.Value = proj_data.DisplayInRecentList.ToString();

                //========NoOfLots=============================================
                XAttribute attrNoOfLots = doc.Root.Attribute(
                    StaticProperties_Helper.ProjectAttributes.NoOfLots.ToString());
                if (attrNoOfLots == null)
                {
                    attrNoOfLots = new XAttribute(
                        StaticProperties_Helper.ProjectAttributes.NoOfLots.ToString(), "");
                }
                attrNoOfLots.Value = proj_data.No_of_Lots.ToString();

                //=====================================================
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        private XDocument CreateNewProjectFile(ProjectFile_ViewModel proj_data)
        {
            try
            {
                var doc = new XDocument(
                    new XDeclaration("1.0", "utf-8", "yes"),
                    new XElement("tenderSchedule",
                        new XAttribute("createdBy", proj_data.CreatedBy),
                        new XAttribute("dateCreated", proj_data.CreateDate.ToString()),
                        new XElement("separablePortions"),
                        new XElement("contractInfo"),
                        new XElement("masterSchedule",
                            new XElement("sections")))); 

                bool results = SaveProjectAttributes(_proj_data, ref doc);

                var sep_portions_el = doc.Root.Element("separablePortions");
                SaveSeparablePortions(proj_data, ref sep_portions_el);

                var ms_sections_el = doc.Root.Element("masterSchedule").Element("sections");
                SaveMasterScheduleSections(proj_data.MasterSchedule.Sections, ref ms_sections_el);

                return doc;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private bool SaveSeparablePortions(ProjectFile_ViewModel proj_data, ref XElement sep_portions_el)
        {
            try
            { 
                sep_portions_el.RemoveAll();

                foreach (var sep_portion in proj_data.SeparablePortions)
                {
                    var sep_el = new XElement("separablePortion",
                              new XAttribute("name", sep_portion.Name),
                              new XAttribute("startingRow", sep_portion.StartingRow),
                              new XAttribute("id", sep_portion.Id));

                    sep_portions_el.Add(sep_el);

                    var sections_el = new XElement("sections");
                    sep_el.Add(sections_el);

                    foreach (var section in sep_portion.Sections)
                    {
                        var section_el = new XElement("section",
                            new XAttribute("id", section.Id),
                            new XAttribute("name", section.Section_Name),
                            new XAttribute("number", section.Section_Number),
                            new XAttribute("startRow", section.StartRow),
                            new XAttribute("endRow", section.EndRow),
                            new XAttribute("subTotalRow", section.SubTotalRow));
                        sections_el.Add(section_el);

                        foreach (var item in section.Items)
                        {
                            var item_el = new XElement("item",
                                    new XAttribute("id", item.Id),
                                    new XAttribute("masterScheduleId", item.MasterSchedule_Id),
                                    new XAttribute("selected", item.Selected),
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
                            var sub_sections_el = new XElement("subSections");
                            section_el.Add(sub_sections_el);

                            foreach (var child_section in section.Children)
                            {
                                var sub_section_el = new XElement("subSection",
                                new XAttribute("id", child_section.Id),
                                new XAttribute("name", child_section.Details),
                                new XAttribute("number", section.Section_Number));
                                sub_sections_el.Add(sub_section_el);

                                foreach (var item in child_section.Children)
                                {
                                    var item_el = new XElement("item",
                                            new XAttribute("id", item.Id),
                                            new XAttribute("masterScheduleId", item.MasterSchedule_Id),
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
                }
                
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }
         
        private bool SaveMasterScheduleSections(List<Section_Model> sections, ref XElement sections_el)
        {
            try
            {
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
                                new XAttribute("id", item.Id),
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
                        var sub_sections_el = new XElement("subSections");
                        section_el.Add(sub_sections_el);

                        foreach (var child_section in section.Children)
                        {
                            var sub_section_el = new XElement("subSection",
                            new XAttribute("id", child_section.Id),
                            new XAttribute("name", child_section.Details),
                            new XAttribute("number", section.Section_Number));
                            sub_sections_el.Add(sub_section_el);

                            foreach (var item in child_section.Children)
                            {
                                var item_el = new XElement("item",
                                        new XAttribute("id", section.Id),
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

        private bool SaveContractInfo(Contract_Model contract_Info, ref XDocument doc)
        {
            try
            {
                if (contract_Info == null) return true;

                XElement contract_el = null; 
                if (doc.Element("tenderSchedule").Element("contractInfo") == null)
                    doc.Element("tenderSchedule").Add(new XElement("contractInfo"));
                contract_el = doc.Element("tenderSchedule").Element("contractInfo");

                XElement jobEl = null;
                if (contract_el.Element("jobNumber") == null)
                    contract_el.Add(new XElement("jobNumber"));
                jobEl = contract_el.Element("jobNumber");
                if (contract_Info?.JobNumber != null)
                    jobEl.Value = contract_Info.JobNumber;

                XElement contractTitle_el = null;
                if (contract_el.Element("contractTitle")== null) 
                    contract_el.Add(new XElement("contractTitle"));
                contractTitle_el = contract_el.Element("contractTitle");
                if (contract_Info?.ContractTitle != null)
                    contractTitle_el.Value = contract_Info.ContractTitle;

                XElement typeOfWork_el= null;
                if (contract_el.Element("typeOfWork") == null)
                    contract_el.Add(new XElement("typeOfWork"));
                typeOfWork_el = contract_el.Element("typeOfWork");
                if (contract_Info?.TypeOfWork != null)
                    typeOfWork_el.Value = contract_Info.TypeOfWork;

                XElement client_el = null;
                if (contract_el.Element("client") == null)
                    contract_el.Add(new XElement("client"));
                client_el = contract_el.Element("client");
                if (contract_Info?.Client != null)
                    client_el.Value = contract_Info.Client;

                XElement contractor_el = null;
                if (contract_el.Element("contractor") == null) 
                contract_el.Add(new XElement("contractor"));
                contractor_el = contract_el.Element("contractor");
                if (contract_Info?.Contractor != null)
                    contractor_el.Value = contract_Info.Contractor;

                XElement contractorAddressEl = null;
                if (contract_el.Element("contractorAddress") == null)
                    contract_el.Add(new XElement("contractorAddress"));
                contractorAddressEl = contract_el.Element("contractorAddress");
                if (contract_Info?.ContractorAddress != null)
                    contractorAddressEl.Value = contract_Info.ContractorAddress;

                XElement contractSite_el = null;
                if (contract_el.Element("contractSite") == null)
                    contract_el.Add(new XElement("contractSite"));
                contractSite_el = contract_el.Element("contractSite");
                if (contract_Info?.ContractorSite != null)
                    contractSite_el.Value = contract_Info.ContractorSite;

                XElement principalEl = null;
                if (contract_el.Element("principal") == null)
                    contract_el.Add(new XElement("principal"));
                principalEl = contract_el.Element("principal");
                if (contract_Info?.Principal != null)
                    principalEl.Value = contract_Info.Principal;

                XElement principalAddressEl = null;
                if (contract_el.Element("principalAddress") == null)
                    contract_el.Add(new XElement("principalAddress"));
                principalAddressEl = contract_el.Element("principalAddress");
                if (contract_Info?.PrincipalAddress != null)
                    principalAddressEl.Value = contract_Info.PrincipalAddress;

                XElement progressClaimNoEl = null;
                if (contract_el.Element("progressClaimNo") == null)
                    contract_el.Add(new XElement("progressClaimNo"));
                progressClaimNoEl = contract_el.Element("progressClaimNo");
                if (contract_Info?.ProgressClaimNo.ToString() != null)
                    progressClaimNoEl.Value = contract_Info.ProgressClaimNo.ToString();

                XElement paymentNoEl = null;
                if (contract_el.Element("paymentNo") == null)
                    contract_el.Add(new XElement("paymentNo"));
                paymentNoEl = contract_el.Element("paymentNo");
                if (contract_Info?.PaymentNo.ToString() != null)
                    paymentNoEl.Value = contract_Info.PaymentNo.ToString();

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
