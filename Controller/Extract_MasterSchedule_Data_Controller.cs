using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Extract_MasterSchedule_Data_Controller
    {
        public ViewModels.MasterSchedule_ViewModel Extract_Workbook_To_Model(string template_path)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            Workbooks wbs = null;
            Workbook wb = null;
            Worksheet ws = null;
            try
            {
                if (!File.Exists(template_path))
                {
                    MessageBox.Show("Source Workbook Does Not Exists at Given Path: " + template_path);
                    return null;
                }
                //Start Excel and get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application
                {
                    DisplayAlerts = false
                };

                var master_schedule_model = new ViewModels.MasterSchedule_ViewModel();

                wbs = excel.Workbooks;
                wb = wbs.Open(template_path);
                ws = wb.Worksheets[1];

                master_schedule_model.Checksum = Checksum_Helper.GetChecksum(template_path);

                var sections = new Extract_Sections_Controller().Find_Sections(ws);

                int last_row = new Worksheet_Helper().FindLastRow(ws);

                var items_controller = new Extract_Items_Controller();
                items_controller.Find_Items(last_row, ws, ref sections);

                master_schedule_model.Sections = sections;
                master_schedule_model.MasterSchedule_FullPath = 
                                        new FilePath_Helper().MasterScheduleFile_FullPath();

                return master_schedule_model;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
            finally
            {
                if (excel!=null)
                    excel.Quit();

                // Cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();

                if (ws != null)
                    Marshal.ReleaseComObject(ws);
                if (wb != null)
                    Marshal.ReleaseComObject(wb);
                if (wbs != null)
                    Marshal.ReleaseComObject(wbs);
                if (excel != null)
                    Marshal.ReleaseComObject(excel);

                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }
    }
}
