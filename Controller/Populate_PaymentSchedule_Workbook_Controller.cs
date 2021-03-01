using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Populate_PaymentSchedule_Workbook_Controller
    {
        /// <summary>
        /// Creates/Updates a separable portion in the worksheet.
        /// This includes all sections and their respective items.
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="sep_portions"></param>
        /// <returns>bool - returns true if successful.</returns>
        public bool Insert_Items_To_Worksheet(Worksheet ws, 
                        List<SeparablePortion_Model> sep_portions)
        { 
            try
            {
                if (sep_portions == null) return true; 
                foreach (var sep_portion in sep_portions)
                {
                    // create separable portion section
                    Insert_SeparablePortion(sep_portion, sep_portions.Count > 1, ws); 
                } 

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
            finally
            { 
                // Cleanup
                GC.Collect();
                GC.WaitForPendingFinalizers();
 
                if (ws != null) 
                    Marshal.ReleaseComObject(ws);
                 
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }
        }

        /// <summary>
        /// Creates the entire Separable Portion, including the Sep Portion Header if need.
        /// Creates each section and inserts each item for the new section.
        /// </summary>
        /// <param name="sep_portion"></param>
        /// <param name="create_sep_portion_headers"></param>  
        /// <param name="ws"></param>
        private void Insert_SeparablePortion(SeparablePortion_Model sep_portion, 
                                             bool create_sep_portion_headers,Worksheet ws)
        {
            try
            {
                int start_row = -1;
                if (create_sep_portion_headers)
                    start_row = Create_Sep_Portion_Header(sep_portion.Name, ws) + 1;

                if (start_row < 1)
                    start_row = Find_First_Section_Row_Index(ws); 

                int sep_portion_end_row = Find_Sep_Portion_End_Row(start_row, ws);

                foreach (var section in sep_portion.Sections)
                {
                    Insert_Section(section, start_row, sep_portion_end_row, ws);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Searches for the last row in the Separable Section
        /// Returns the row index of the section or -1 if it can't be determined.
        /// Separable Sections are usually defined by the backcolor of the section header row.
        /// </summary>
        /// <param name="start_row"></param>
        /// <param name="ws"></param>
        /// <returns>Integer - Row Index</returns>
        private int Find_Sep_Portion_End_Row(int start_row, Worksheet ws)
        {
            try
            {
                if (!WS_Already_Has_Separable_Portions(ws))
                    return Find_RowIndex_Of_ITEM_Cell(ws) + 2;

                var last_row = new Worksheet_Helper().FindLastRow(ws);

                double sep_portion_color = Find_SeparblePortion_Colour(ws);

                if (sep_portion_color != -1) 
                    for (int row_index = start_row + 1; row_index < last_row; row_index++)
                    {
                        if ((ws.Cells[row_index, 1] as Range).Interior.Color == sep_portion_color)
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

        /// <summary>
        /// Creates the new Separable Portion section header in the worksheet
        /// Returns the row index of the new section
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ws"></param>
        /// <returns>Integer - Row Index</returns>
        private int Create_Sep_Portion_Header(string name, Worksheet ws)
        {
            try
            {
                int row_index = Find_Sep_Portion_Row(name, ws);
                // if row_index > -1 then sep portion name already exists
                if (row_index > -1) return row_index;

                row_index = Find_Next_Sep_Portion_Start_Row(ws);

                if (!Insert_Row(ws, row_index)) return -1;
                (ws.Cells[row_index, 1] as Range).Value2 = name;

               return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        /// <summary>
        /// Inserts a new row into the worksheet.
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="row_index"></param>
        /// <returns>bool - true if row inserted.</returns>
        private bool Insert_Row(Worksheet ws, int row_index)
        { 
            try
            {
                Range line = (Range)ws.Rows[row_index];
                line.Insert();

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        /// <summary>
        /// Determines the row index to start a new Separable Portion Section
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>Integer - Row Index</returns>
        private int Find_Next_Sep_Portion_Start_Row(Worksheet ws)
        {
            try
            {
                if (!WS_Already_Has_Separable_Portions(ws))
                    // if no separable portions then start at the top of the ws
                    return Find_First_Section_Row_Index(ws);
                 
                double separator_color = Find_Separator_Colour(ws);
                int last_row = new Worksheet_Helper().FindLastRow(ws);
                for (int row_index = last_row; row_index >= 1; row_index--)
                {
                    if ((ws.Cells[row_index, 1] as Range).Interior.Color == separator_color)
                        return row_index + 1;
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        /// <summary>
        /// Finds the first Section Group in the Worksheet and Returns the Background Color
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>double Color Number</returns>
        private double Find_Separator_Colour(Worksheet ws)
        { 
            try
            { 
                int row_index =Find_First_Section_Row_Index(ws);
                
                double separator_color = (ws.Cells[row_index, 1] as Range).Interior.Color;
                return separator_color;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        /// <summary>
        /// Finds the first Separable Portion in the Worksheet and Returns the Background Color
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>double Color Number</returns>
        private double Find_SeparblePortion_Colour(Worksheet ws)
        {
            try
            {
                int row_index = -1;
                if (WS_Already_Has_Separable_Portions(ws))
                    row_index = Find_RowIndex_Of_ITEM_Cell(ws) + 2;

                if (row_index == -1) return row_index;

                double separator_color = (ws.Cells[row_index, 1] as Range).Interior.Color;
                return separator_color;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }


        /// <summary>
        /// Search the first 5 rows for the Row Containing the ITEM cell. Likely the first row.
        /// This has found in the second row (not the expected first row), causing issues. 
        /// Return the row index of the ITEM cell if found, else return -1.
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>Integer - Row index</returns>
        private int Find_RowIndex_Of_ITEM_Cell(Worksheet ws)
        {
            try
            { 
                for (int row_index = 0; row_index < 5; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.ToLower().Trim() == "item")
                    {
                        return row_index;
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        /// <summary>
        /// Determines the first sections row index by finding the index of the ITEM cell
        /// and checking to see if there is a Separable Portion row
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>Integer Row Index</returns>
        private int Find_First_Section_Row_Index(Worksheet ws)
        { 
            try
            {
                var first_row = Find_RowIndex_Of_ITEM_Cell(ws);
                if (WS_Already_Has_Separable_Portions(ws))
                    first_row++;
                return first_row + 2;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }


        /// <summary>
        /// Searches for the separable portion name in the "A" cells. 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ws"></param>
        /// <returns>Integer Row index of matching row, -1 if no match found</returns>
        private int Find_Sep_Portion_Row(string name, Worksheet ws)
        {
            try
            {
                if (!WS_Already_Has_Separable_Portions(ws)) return -1;

                int last_row = new Worksheet_Helper().FindLastRow(ws);
                for (int row_index = 2; row_index < 5; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.ToLower().Trim()== name)
                    {
                        return row_index; 
                    }
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            } 
        }


        /// <summary>
        /// Searchs the first 5 rows looking for Separable Portion in the "A" cells.
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>bool true If Found, or false If Not Found.</returns>
        private bool WS_Already_Has_Separable_Portions( Worksheet ws)
        {
            try
            {  
                for (int row_index = 2; row_index < 5; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.ToLower().Trim().Contains("separable portion"))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }


        /// <summary>
        /// Updates an existing section if a matching section exists,
        /// otherwise creates the new section, ordering the location
        /// of the section in the document numerically according to the section number.
        /// </summary>
        /// <param name="section"></param>
        /// <param name="sep_portion_start_row"></param>
        /// <param name="sep_portion_end_row"></param> 
        /// <param name="ws"></param>
        /// <returns>bool true If Successful</returns>
        private bool Insert_Section(Section_Model section, int sep_portion_start_row, 
                                    int sep_portion_end_row, Worksheet ws)
        { 
            try
            {
                if (section.Items.Count == 0)
                    return false;

                // does the section already exists
                var row_index = Find_Existing_SectionHeader_RowIndex(section.Section_Number,
                                                      section.Section_Name, sep_portion_start_row, 
                                                      sep_portion_end_row, ws);
                if (row_index == -1)
                {
                    row_index = Create_Section_Header(section.Section_Number, section.Section_Name, 
                                                      sep_portion_start_row, sep_portion_end_row, ws); 
                } 

                var section_start_row = row_index;
                var section_end_row = Find_Section_End_Row_Index(row_index, ws);

                row_index++;

                // Find Insertion Row
                foreach (var item in section.Items)
                {
                    var item_index = Find_Item_Index_In_Section(
                                             section_start_row,section_end_row, 
                                             item.ItemNumber, item.SubItem, ws);
                    if (item_index > -1)
                        row_index = item_index;

                    (ws.Cells[row_index, 1] as Range).Value2 = item.ItemNumber;
                    (ws.Cells[row_index, 2] as Range).Value2 = item.Details;
                    (ws.Cells[row_index, 3] as Range).Value2 = item.Quantity;
                    (ws.Cells[row_index, 15] as Range).Value2 = item.Comment;
                    row_index++;
                }

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }


        /// <summary>
        /// Searches the Section for the item number (and sub item if any)
        /// Returns the Row Index of the item if found, else returns -1.
        /// </summary>
        /// <param name="start_row_index"></param>
        /// <param name="end_row_index"></param>
        /// <param name="item_number_str"></param>
        /// <param name="sub_item"></param>
        /// <param name="ws"></param>
        /// <returns>Integer Row Index</returns>
        private int Find_Item_Index_In_Section(int start_row_index, int end_row_index, 
            int item_number, string sub_item, Worksheet ws)
        {
            try
            {
                var last_item_no = -1;
                for (int row_index = start_row_index; row_index < end_row_index; row_index++)
                {
                    if (string.IsNullOrEmpty( (ws.get_Range("A" + row_index.ToString()) 
                                as Range ).Value2?.ToString())) continue;

                    int cell_item_number = -1;
                    
                    if (int.TryParse((ws.get_Range("A" + row_index.ToString())
                                as Range).Value2?.ToString().Trim(), out int ws_item_no))
                    {
                        cell_item_number = ws_item_no;
                    }
                    string sub_item_value = (ws.get_Range("B" + row_index.ToString()) 
                                                            as Range).Value2?.ToString().Trim();

                    if (cell_item_number>-1)
                    {
                        // this row has an item number
                        last_item_no = cell_item_number;
                        if (cell_item_number == item_number)
                        {
                            if (sub_item.Trim().ToLower() == sub_item_value.ToLower())
                                return row_index;
                        }
                    }
                    else
                    {
                        // this must be a sub item row
                        if (last_item_no == item_number)
                        {
                            if (sub_item.Trim().ToLower() == sub_item_value.ToLower())
                                return row_index;
                        }
                    }  
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }   
        } 


        /// <summary>
        /// Iterates the rows starting from the start row index until it finds the next 
        /// row whose back colour matches the separator color.
        /// See: Find_Separator_Colour(Worksheet)
        /// </summary>
        /// <param name="start_row_index"></param>
        /// <param name="ws"></param>
        /// <returns>Integer Row Index</returns>
        private int Find_Section_End_Row_Index(int start_row_index, Worksheet ws)
        {
            try
            { 
                double separator_color = Find_Separator_Colour(ws);
                var last_row = new Worksheet_Helper().FindLastRow(ws); 

                for (int row_index = start_row_index + 1; row_index < last_row; row_index++)
                {
                    if (separator_color == (ws.Cells[row_index, 1] as Range).Interior.Color)
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

        /// <summary>
        /// Find the Row Index of the section that matches the section number and section name
        /// </summary>
        /// <param name="section_number"></param>
        /// <param name="section_name"></param>
        /// <param name="sep_portion_start_row"></param>
        /// <param name="sep_portion_last_row"></param>
        /// <param name="ws"></param>
        /// <returns>Integer row index</returns>
        private int Find_Existing_SectionHeader_RowIndex(int section_number, string section_name, 
            int sep_portion_start_row, int sep_portion_last_row, Worksheet ws)
        { 
            try
            {  
                for (int row_index = sep_portion_start_row; row_index < sep_portion_last_row; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_A_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (!(int.TryParse(cell_A_value.Trim(), out var number))) continue;

                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    if (number != section_number) continue;

                    string cell_B_value = (ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_B_value.ToLower().Trim() == section_name.ToLower()) 
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



        /// <summary>
        /// Finds the Row Index in the document where the section should be inserted
        /// </summary>
        /// <param name="section_number"></param>
        /// <param name="section_name"></param>
        /// <param name="ws"></param>
        /// <returns>Integer Row Index of Insertion Point</returns>
        private int Find_SectionHeader_Insert_Row_Index(int section_number, int sep_portion_start_row,
                                                     int sep_portion_end_row,  Worksheet ws)
        {
            try
            { 
                var sections = Find_AllSections(sep_portion_start_row, sep_portion_end_row, ws);

                if (sections == null || sections.Count == 0)
                    return sep_portion_start_row;

                var sect = sections.Find(s => s.Section_Number == section_number);
                if (sect != null)
                    // this section already exists
                    return sect.StartRow;

                if (sections[0].Section_Number > section_number)
                    // insert as the first section
                    return sep_portion_start_row;

                for (int sec_cnt = 0; sec_cnt < sections.Count; sec_cnt++)
                { 
                    var current_section = sections[sec_cnt];

                    Section_Model next_section = null;
                    if (sec_cnt < sections.Count - 2)
                        next_section = sections[sec_cnt + 1];

                    // check if section number is between two existing sections
                    if (current_section.Section_Number < section_number)
                    {
                        if (next_section != null)
                            if (next_section.Section_Number > section_number)
                                // the section number is greater than the current section
                                // and less than the next section, 
                                // it must go in between the two.
                                return current_section.SubTotalRow + 1;
                    }   
                } 
                return sections[sections.Count -1].SubTotalRow + 1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        /// <summary>
        /// Examines the document and finds all sections and populates the 
        /// section's name, number, start row and end row
        /// </summary>
        /// <param name="ws"></param>
        /// <returns>Returns a list of Section objects</returns>
        private List<Section_Model> Find_AllSections( int sep_portion_start_row,
                                                        int sep_portion_end_row, Worksheet ws)
        {
            try
            { 
                var sections = new List<Section_Model>();

                double separator_color = Find_Separator_Colour(ws);
                for (int row_index = sep_portion_start_row; row_index < sep_portion_end_row; row_index++)
                {
                    if((ws.Cells[row_index, 1] as Range).Interior.Color == separator_color)
                    {
                        if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                        string cell_A_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                        if (!(int.TryParse(cell_A_value.Trim(), out var number))) continue;
                        string cell_B_value = (ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString();
                        var end_row_index = Find_Section_End_Row_Index(row_index, ws);
                        var section = new Section_Model
                        {
                            Section_Number = number,
                            Section_Name = cell_B_value,
                            StartRow = row_index,
                            SubTotalRow = end_row_index
                        };
                        sections.Add(section);
                        row_index = end_row_index + 1;
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

        /// <summary>
        /// Inserts the Section Number and Section Name to the appropriate row.
        /// Return the row index of the newly inserted section
        /// </summary>
        /// <param name="section_Name"></param>
        /// <param name="ws"></param>
        /// <returns>Row Index as Integer</returns>
        private int Create_Section_Header(int section_number, string section_name, int sep_portion_start_row,
                                                     int sep_portion_end_row, Worksheet ws)
        {
            try
            {
                int row_index = Find_SectionHeader_Insert_Row_Index(section_number, sep_portion_start_row,
                                                      sep_portion_end_row, ws);
                if (row_index > -1) return -1;

                if (!string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString()))
                    Insert_Row(ws, row_index);

                (ws.get_Range("A" + row_index.ToString()) as Range).Value2 = section_number;
                (ws.get_Range("B" + row_index.ToString()) as Range).Value2 = section_name; 

                return row_index;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        } 
       
    }
}
