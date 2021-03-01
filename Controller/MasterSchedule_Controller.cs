using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class MasterSchedule_Controller
    {
        public async Task<bool> Create_MasterSchedule_File()
        { 
            try
            {
                var path = Properties.Settings.Default.MasterScheduleFullPath;
                if (!File.Exists(path)) return false;

                var extract_controller = new Extract_MasterSchedule_Data_Controller();
                var masterSchedule = await Task.Run(() => extract_controller.Extract_Workbook_To_Model(path));

                IWriter writer = new Save_MasterSchedule_Helper(masterSchedule);
                masterSchedule.WriteToFile(writer);

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        public MasterSchedule_ViewModel Load_MasterSchedule_From_File()
        { 
            try
            {
                var master_data = new MasterSchedule_ViewModel();
                master_data.LoadFromFile();

                return master_data;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }
    }
}
