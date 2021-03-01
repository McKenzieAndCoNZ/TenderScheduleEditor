using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Open_AllProjects_Controller
    {
        public List<ProjectFile_ViewModel> ReturnAllProjects()
        { 
            try
            {
                var projects_path = new FilePath_Helper().ProjectsPath();
                string[] dirs = Directory.GetDirectories(projects_path);
                if (dirs == null || dirs.Count() == 0)
                    return null;

                var projects = new List<ProjectFile_ViewModel>();
                foreach (string dir in dirs)
                {
                    string[] files = Directory.GetFiles(dir, "*.pymt");
                    foreach (string file_path in files)
                    {
                        FileInfo info = new FileInfo(file_path);
                        DateTime dt = File.GetLastWriteTime(file_path); 

                        var proj_data = new Open_Project_Controller().LoadProjectData(file_path);
                        if (proj_data == null) continue;
                        projects.Add(proj_data);
                    }
                }
                return projects;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }
    }
}
