namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class ProjectSettings_ViewModel
    {

        private static string _project_full_name = string.Empty;
        public static string ProjectFullName
        {
            get
            {
                return _project_full_name;
            }
        }

        private static string _project_name = string.Empty;
        public static string ProjectName
        {
            get
            {
                return _project_name;
            }
        } 

        private static string _project_id = string.Empty;
        public static string ProjectId
        {
            get
            {
                return _project_id;
            }
        }
         
        private static string _project_file_name = string.Empty; 
        public static string ProjectFileLocation
        {
            get
            {
                return _project_file_name;
            }
        } 
    }

}
