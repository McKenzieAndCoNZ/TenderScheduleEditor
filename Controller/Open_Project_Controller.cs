using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Open_Project_Controller
    {
        public bool OpenProject(string project_path)
        { 
            try
            {
                if (!File.Exists(project_path))
                {
                    MessageBox.Show("The Project Was Not Found At the Supplied Path: \r" + project_path);
                    return false;
                }

                var project = LoadProjectData(project_path);

                MainForms.Project = project;

                MainForms.WB_CRUDForm.LoadProject(project);

                MainForms.WB_CRUDForm.Show();

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        public ProjectFile_ViewModel LoadProjectData(string project_path)
        {
            try
            {
                var project_data = new ProjectFile_ViewModel 
                { 
                    ProjectName = Path.GetFileNameWithoutExtension(project_path),
                    LastEdited = DateTime.Now,
                    LastEditedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    Project_FullPath = project_path,
                    MasterSchedule = MainForms.MasterSchedule
                };
                var doc = XDocument.Load(project_path);
                var root_el = doc.Element("tenderSchedule");

                var showInRecentList = true;
                if (bool.TryParse(root_el.Attribute("showInRecentList")?.Value, out var boolResult))
                    showInRecentList = boolResult;
                project_data.DisplayInRecentList = showInRecentList;

                if (!string.IsNullOrEmpty(root_el.Attribute("lastEditedBy")?.Value))
                    project_data.LastEditedBy = root_el.Attribute("lastEditedBy")?.Value;
                 
                var createdDate = DateTime.Now;
                if (DateTime.TryParse(root_el.Attribute("dateCreated")?.Value, out var dateResult))
                    createdDate = dateResult;
                project_data.CreateDate = createdDate;

                if (!string.IsNullOrEmpty(root_el.Attribute("createdBy")?.Value))
                    project_data.CreatedBy = root_el.Attribute("createdBy")?.Value;

                var sep_els = root_el.Element("separablePortions"
                                                            ).Elements("separablePortion");

                foreach (XElement sep_el in sep_els)
                {
                    var sep_portion = new SeparablePortion_Model(sep_el);
                    if (sep_portion != null)
                        project_data.SeparablePortions.Add(sep_portion);
                }

                var contract_el = root_el.Element("contractInfo");
                if (contract_el == null) return project_data;

                var contract_data = new Contract_Model(contract_el);
                if (contract_data != null)
                    project_data.Contract_Information = contract_data;

                return project_data;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            } 
        } 
    }
}
