using Microsoft.Office.Interop.Excel;
using System;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class Sep_Portions_Helper
    {
       public bool Has_Sep_Portions(Worksheet sheet)
        { 
            try
            { 
                int last_row = new Worksheet_Helper().FindLastRow(sheet);
                for (int row_index = 2; row_index < last_row; row_index++)
                {
                    if (string.IsNullOrEmpty((sheet.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (sheet.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.Contains("SEPARABLE PORTION")) return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            } }
    }
}
