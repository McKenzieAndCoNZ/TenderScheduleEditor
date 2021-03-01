using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class Worksheet_Helper
    {
        public int Find_Last_Populated_Row(Worksheet ws)
        { 
            try
            {
                int empty_cell_count=1;

                int last_row = ws.Cells.SpecialCells( XlCellType.xlCellTypeLastCell, Type.Missing).Row; 
                 
                for (int row_index = 1; row_index < last_row; row_index++)
                {       
                    bool cell_is_blank = string.IsNullOrEmpty((ws.Cells[row_index, 1 ] as Range).Value2?.ToString());
                    if (cell_is_blank)
                        cell_is_blank = string.IsNullOrEmpty((ws.Cells[row_index, 2] as Range).Value2?.ToString());
                    if (cell_is_blank)
                    {
                        if (empty_cell_count > 10)
                        { return row_index; }
                        else
                            empty_cell_count += 1;
                    }
                    else
                        empty_cell_count = 0; 
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        internal int FindLastRow(Worksheet ws)
        {
            return ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing).Row; 
        }

        public int Find_Section_Row(int section_no, string section_name, 
                                    int start_row, int last_row, Worksheet ws)
        {
            try
            {  
                for (int row_index = start_row; row_index < last_row; row_index++)
                { 
                    if ((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString() == section_no.ToString())
                        if ((ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString().ToLower().Trim() == section_name.ToLower().Trim())
                            return row_index;
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        public int Find_EndSection_Row(int section_no, int start_row, Worksheet ws)
        {
            try
            {
                var end_section_name = "Total Section " + section_no.ToString();
                int last_row = ws.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing).Row;

                for (int row_index = start_row; row_index < last_row; row_index++)
                {
                    if ((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString().ToLower().Trim() == end_section_name.ToLower().Trim())
                        return row_index;
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }
    }
}
