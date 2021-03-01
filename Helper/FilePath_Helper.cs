using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class FilePath_Helper
    {
        public string ProjectFullPath(string project_name)
        { 
            try
            {
                project_name = project_name.Replace(" ", "_").Trim(); 
                var proj_path = ProjectsPath();

                proj_path += "\\" + project_name;

                if (!Directory.Exists(proj_path))
                    Directory.CreateDirectory(proj_path);

                proj_path += "\\" + project_name + Properties.Settings.Default.TenderSchedule_FileType;

                return proj_path;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + 
                    "\\" + project_name + Properties.Settings.Default.TenderSchedule_FileType;
            }
        }

        internal string ProjectsPath()
        {
            var proj_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            proj_path += "\\MCCL\\Projects";
            return proj_path;
        }

        public string MasterScheduleFile_FullPath()
        {
            try
            { 
                var proj_path = MasterSchedule_DirPath();

                if (!Directory.Exists(proj_path))
                    Directory.CreateDirectory(proj_path);

                var fileType = Properties.Settings.Default.MasterScheduleFileType;

                string file  = Directory.GetFiles(proj_path, "*"+ fileType, 
                                SearchOption.AllDirectories).FirstOrDefault();
                 
                return file;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return string.Empty;
            }
        }

        internal string MasterSchedule_DirPath()
        {
            var master_dir_path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            master_dir_path += "\\MCCL\\MasterSchedule";
            return master_dir_path;
        }
    }
}
