using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Create_NewProject_Controller
    { 
        public ProjectFile_ViewModel Create_Project(string project_name, string output_path = "")
        { 
            try
            {
                var proj_path = new FilePath_Helper().ProjectFullPath(project_name);
                if (File.Exists(proj_path)) return null;

                var project = new ProjectFile_ViewModel
                {
                    ProjectName = project_name,
                    Project_FullPath = proj_path, 
                    CreateDate = DateTime.Now,
                    CreatedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    LastEditedBy = System.Security.Principal.WindowsIdentity.GetCurrent().Name,
                    Id = Guid.NewGuid().ToString("N"),
                    DisplayInRecentList = true,
                    OutputDirectory = output_path,
                    MasterSchedule = MainForms.MasterSchedule,
                    Status = StaticProperties_Helper.Status.Design.ToString()
                };
                project.SeparablePortions.Add(new SeparablePortion_Model
                {
                    Id = Guid.NewGuid().ToString("N"),
                    Name = "Separable Portion 1"
                });
                if (MainForms.MasterSchedule?.Sections!=null)
                    foreach (var ms_section in MainForms.MasterSchedule.Sections)
                    {
                        var prj_section = new Section_Model(ms_section);

                        if (prj_section != null)
                            project.SeparablePortions[0].Sections.Add(prj_section as Section_Model);
                    }

                return project;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        } 
    }
}
