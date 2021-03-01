using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Extract_Sections_Controller
    {
        public List<Section_Model> Find_Sections(Worksheet ws)
        { 
            try
            {
                var sections = new List<Section_Model>();
                int summary_row = -1;
                // look for SUMMARY - around row 18 
                for (int row_index = 2; row_index < 100; row_index++)
                {
                    var range_str = "A"+ row_index.ToString();
                    if (string.IsNullOrEmpty((ws.get_Range(range_str) as Range).Value2?.ToString())) continue; 
                    string cell_value = (ws.get_Range(range_str) as Range).Value2.ToString();
                    if (cell_value.ToLower().Trim() == "summary")
                    {
                        summary_row = row_index;
                        break;
                    }
                }

                int total_row = -1;
                // record the different sections between the 
                for (int row_index = summary_row; row_index < 100; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString(); 
                    if (cell_value.Trim().ToLower() == "total")
                    {
                        total_row = row_index;
                        break;
                    }
                } 

                //   for each section for the start and end row
                //      record the items for each section
                int last_row = new Worksheet_Helper().FindLastRow(ws);
                for (int row_index = summary_row+1; row_index < total_row; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString()))  continue;
                    string cell_value = (ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.ToLower().Contains("section"))
                    { 
                        cell_value = cell_value.Replace("SECTION","").Trim();
                        string[] section_items = cell_value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        var section = new Section_Model { Id = Guid.NewGuid().ToString("N")};
                        string sec_number_as_string = section_items[0] as string;
                        if (int.TryParse(sec_number_as_string,out var sec_num))
                            section.Section_Number = sec_num;

                        section.Section_Name = cell_value.Replace(sec_number_as_string, "").Trim();
                        sections.Add(section);
                    }
                }
                return sections;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }
    }
}
