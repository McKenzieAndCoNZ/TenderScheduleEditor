using Microsoft.Office.Interop.Excel;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Extract_Items_Controller
    {
        public bool Find_Items(int last_row, Worksheet ws, ref List<Section_Model> sections)
        { 
            try
            {
                double separator_color = 0;
                Find_Sections_And_SubSections_RowIndexes(last_row, ws, ref separator_color, ref sections);

                foreach (var section in sections)
                {
                    int last_item_no = section.Section_Number;
                    for (int row_index = section.StartRow + 1; row_index <= section.EndRow; row_index++)
                    {
                        var item_model = GetSectionItem(ws, section, row_index, ref last_item_no);

                        section.Items.Add(item_model);
                    }

                    if (section.Children.Count > 0)
                        foreach (var child_item in section.Children)
                        {
                            for (int row_index = child_item.StartRow + 1; 
                                                row_index <= child_item.EndRow; row_index++)
                            {
                                var item_model = GetSectionItem(ws, section, row_index, ref last_item_no);

                                child_item.Children.Add(item_model);
                            }
                        }
                } 
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        private static Item_ViewModel GetSectionItem(Worksheet ws, Section_Model section, 
            int row_index, ref int last_item_no)
        {
            try
            { 
                var subItem = "";
                if (int.TryParse((ws.get_Range("A" + row_index.ToString())
                                        as Range).Value2?.ToString(), out int item_no))
                {
                    last_item_no = item_no;
                }
                else
                {
                    subItem = (ws.get_Range("A" + row_index.ToString())
                                        as Range).Value2?.ToString();
                }

                var details = (ws.get_Range("B" + row_index.ToString()) as Range).Value2?.ToString();
                var unit = (ws.get_Range("C" + row_index.ToString()) as Range).Value2?.ToString();
                var qty = (ws.get_Range("D" + row_index.ToString()) as Range).Value2?.ToString();

                object parent = section;
                if (subItem != string.Empty)
                { 
                    var item_number = last_item_no;
                    if (section.Section_Number == last_item_no)
                    {
                        parent = section;
                    }
                    else
                    {
                        if (details == "Pond 1 including geotextile-lined outlet weir and lined channel")
                        {
                            var st = string.Empty;
                        }
                        if (section.Items != null)
                            parent = Find_SubItem_Parent(section.Items, last_item_no); 

                        if (parent == null)
                        {
                            if (section.Children.Count > 0)
                                parent = Find_SubItem_Parent(section.Children, last_item_no);
                        }
                    } 
                }

                if (parent == null)
                {
                    var st = string.Empty;
                }

                var Item_Model = new Item_ViewModel
                {
                    Id = Guid.NewGuid().ToString("N"),
                    ItemNumber = last_item_no,
                    SubItem = subItem,
                    Details = details,
                    Unit = unit,
                    Quantity = qty,
                    Parent = parent
                };

                if (parent is Item_ViewModel)
                    ((Item_ViewModel)parent).Children.Add(Item_Model);
                return Item_Model;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            } 
        }

        private static dynamic Find_SubItem_Parent(List<Item_ViewModel> items, int item_no)
        {
            try
            {
                Item_Model parent = null;
                foreach (var item in items)
                {
                    if (item.ItemNumber == item_no &&
                        item.SubItem == string.Empty)
                    {
                        // must be the parent item
                        parent = item;
                        return parent;
                    }
                    else if (item.Children.Count > 0)
                    {
                        parent = Find_SubItem_Parent(item.Children, item_no);
                        if (parent != null)
                            return parent;
                    }
                }
                return parent;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private bool Find_Sections_And_SubSections_RowIndexes(int last_row, Worksheet ws,ref double separator_color, ref List<Section_Model> sections)
        {
            try
            {
                var item_row = -1;
                // look for ITEM - around row 42 
                for (int row_index = 2; row_index < 100; row_index++)
                {
                    if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString())) continue;
                    string cell_value = (ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString();
                    if (cell_value.ToLower().Trim() == "item")
                    {
                        item_row = row_index;
                        break;
                    }
                }

                int start_row = item_row + 1; 

                separator_color = (ws.Cells[start_row, 1] as Range).Interior.Color;

                var helper = new Worksheet_Helper();
                foreach (var section in sections)
                {
                    var section_end_row_found = false;

                    var section_row = helper.Find_Section_Row(section.Section_Number,
                                       section.Section_Name, start_row, last_row, ws);
                    if (section_row == -1)
                        continue;

                    var sub_total_row = helper.Find_EndSection_Row(section.Section_Number, start_row, ws);

                    section.StartRow = section_row;
                    section.EndRow = sub_total_row - 1;
                    section.SubTotalRow = sub_total_row;

                    for (int row_index = section_row + 1; row_index < sub_total_row; row_index++)
                    {
                        if (string.IsNullOrEmpty((ws.get_Range("A" + row_index.ToString()) as Range).Value2?.ToString()))
                        {
                            if (!string.IsNullOrEmpty((ws.get_Range("B" + row_index.ToString())
                                                                        as Range).Value2?.ToString()))
                            {
                                XlUnderlineStyle isUnderLined = (XlUnderlineStyle)(ws.get_Range(
                                                    "B" + row_index.ToString()) as Range).Font.Underline;

                                if (isUnderLined != XlUnderlineStyle.xlUnderlineStyleNone &&
                                    isUnderLined != XlUnderlineStyle.xlUnderlineStyleNone)
                                {
                                    var section_name = (ws.get_Range("B" + row_index.ToString())
                                                                as Range).Value2.ToString();
                                    var sub_section = new Item_ViewModel
                                    {
                                        Id = Guid.NewGuid().ToString(),
                                        StartRow = row_index,
                                        EndRow = section.SubTotalRow - 1,
                                        SubItem = section_name
                                    };
                                    if (!section_end_row_found)
                                    {
                                        section_end_row_found = true;
                                        section.EndRow = row_index - 1;
                                    }
                                    else
                                    {
                                        if (section.Children.Count > 0)
                                        {
                                            // if this is the second child and later
                                            // the end row of the last child in the list is the
                                            // previous row to the start row of the next sub section
                                            section.Children[section.Children.Count - 1].EndRow = row_index - 1;
                                        }
                                    }
                                    section.Children.Add(sub_section);
                                }
                                else if (row_index == section_row + 1)
                                {
                                    section.Description = (ws.get_Range("B" + row_index.ToString()) 
                                            as Range).Value2.ToString().Trim();
                                }
                            } 
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        } 
    }
}
