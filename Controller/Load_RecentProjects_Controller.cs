using ComponentFactory.Krypton.Ribbon;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using PaymentsScheduleTemplateCreator.Views;
using System;
using System.Collections.Generic;
using System.IO;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Load_RecentProjects_Controller
    {
        public List<KryptonRibbonRecentDoc> Recent_Project_Ribbon_Documents()
        {
            try
            {
                var recents = new List<KryptonRibbonRecentDoc>();

                var projects_path = new FilePath_Helper().ProjectsPath();  

                if (!Directory.Exists(projects_path))
                    Directory.CreateDirectory(projects_path);

                string[] dirs = Directory.GetDirectories(projects_path);

                foreach (string dir in dirs)
                {
                    string[] files = Directory.GetFiles(dir, "*.pymt");
                    foreach (string file_path in files)
                    {
                        FileInfo info = new FileInfo(file_path);
                        DateTime dt = File.GetLastWriteTime(file_path);
                        string date_string = GetDateString(dt);

                        var proj_data = new Open_Project_Controller().LoadProjectData(file_path);
                        if (proj_data == null) continue;
                        if (proj_data.DisplayInRecentList)
                            recents.Add(new RibRecentDoc_View().RibRecentDoc(
                                    info.Name, date_string, info.FullName));
                    }
                }
 
                return recents;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private string GetDateString(DateTime dt)
        {
            try
            {
                var date_string = dt.ToString("ddd") + " at " + dt.ToString("hh:mm tt");
                var ts = DateTime.Now.Subtract(dt);
                if (ts.TotalDays > 7)
                    date_string = dt.ToString("dd MMMM");

                return date_string;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return dt.ToShortDateString();
            }
        }
    }
}
