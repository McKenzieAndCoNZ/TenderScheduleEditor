using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Extract_Master_Items_Workbook
    {
        public MasterSchedule_Workbook_Model CreateMasterItemsData(string path_to_template) {
            try
            {
                if (!File.Exists(path_to_template))
                {
                    MessageBox.Show("Master Items Workbook Does Not Exists at Give Path: " + path_to_template);
                    return null;
                }

                var extract_controller = new Extract_MasterSchedule_Data_Controller();
                var template = extract_controller.Extract_Workbook_To_Model(path_to_template);

                return template;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        } 
    }
}
