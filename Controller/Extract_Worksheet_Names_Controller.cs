using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Extract_Worksheet_Names_Controller
    { 
        public string Find_PaymentSchedule_Name(Workbook wb)
        { 
            try
            {
                foreach (Worksheet ws in wb.Worksheets)
                {
                    if (ws.Name.ToLower() == "payment schedule")
                        return "Payment Schedule";
                }
                foreach (Worksheet ws in wb.Worksheets)
                {
                    if (ws.Visible == XlSheetVisibility.xlSheetVisible)
                        return ws.Name;
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return string.Empty;
            }
        }

        public string Find_Latest_Worksheet_Name(Workbook wb)
        { 
            try
            {
                List<string> months = "Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec".Split(',').ToList<string>();
                  
                var greatest_ws_year =-1;  
                int latest_ws_month_index = -1;
                Worksheet latest_ws = null;
                foreach (Worksheet worksheet in wb.Worksheets )
                {
                    if (worksheet.Visible != XlSheetVisibility.xlSheetVisible)
                        continue;

                    var ws_year = worksheet.Name.Substring(
                            worksheet.Name.Length - 2,2);

                    if (int.TryParse(ws_year, out var year))
                    {
                        if (year > greatest_ws_year)
                        {
                            greatest_ws_year = year;
                            latest_ws = worksheet;
                            latest_ws_month_index = -1;
                            continue;
                        }
                        else if (year < greatest_ws_year)
                            continue; 
                    }

                    int current_month_index = Find_Month_Index(worksheet.Name);
                    if (current_month_index > latest_ws_month_index)
                    {
                        latest_ws_month_index = current_month_index;
                        latest_ws = worksheet;
                    } 
                } // next worksheet
                return latest_ws.Name;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return string.Empty;
            }
        }

        private int Find_Month_Index(string name)
        {
            try
            {
                List<string> months = "Jan,Feb,Mar,Apr,May,Jun,Jul,Aug,Sep,Oct,Nov,Dec".Split(',').ToList<string>();
                var month = months.Find(m => name.Contains(m));
                if (string.IsNullOrEmpty( month )) return -1;
                return name.IndexOf(month); 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }
    }
}
