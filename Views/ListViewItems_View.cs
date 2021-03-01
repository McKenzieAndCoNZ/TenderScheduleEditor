using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class ListViewItems_View
    {
        public ListViewItem[] ListViewItems(Section_Model section)
        {
            try
            {
                if (section.Section_Name == "EARTHWORKS")
                {
                    var st = string.Empty;
                }

                ListViewItem[] items = LoadSectionItems(section);

                if (section.Children.Count > 0)
                {
                    var itemsList = items.ToList();
                    foreach (var child_item in section.Children)
                    {
                        var child_listview_item = CreateListViewItem(child_item, false,
                                    new Font("Microsoft Sans Serif", 8, FontStyle.Underline));
                        if (child_listview_item != null)
                            itemsList.Add(child_listview_item);

                        ListViewItem[] child_items = LoadItemGroup_Children(child_item);
                        itemsList.AddRange(child_items.ToList());
                    }
                    items = itemsList.ToArray();
                }

                return items;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private static ListViewItem[] LoadSectionItems(Section_Model master_section)
        {
            try
            {
                ListViewItem[] items = new ListViewItem[master_section.Items.Count];
                var cnt = 0;
                foreach (var item in master_section.Items)
                { 
                    var lvi = CreateListViewItem(item, item.Selected);
                    if (lvi != null)
                    {
                        items[cnt] = lvi;
                        cnt += 1;
                    } 
                }
                return items;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private static ListViewItem[] LoadItemGroup_Children(Item_Model list_group_parent)
        {
            try
            {
                ListViewItem[] items = new ListViewItem[list_group_parent.Children.Count];
                var cnt = 0;
                foreach (var item in list_group_parent.Children)
                { 
                    var lvi = CreateListViewItem(item, item.Selected);
                    if (lvi != null)
                    {
                        items[cnt] = lvi;
                        cnt += 1;
                    } 
                }
                return items;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }


        private static ListViewItem CreateListViewItem(Item_Model item, bool isChecked, 
                                                       Font font = null)
        {
            try
            {
                var item_number = "";
                if (string.IsNullOrEmpty(item.SubItem) && item.ItemNumber > -1)
                    item_number = item.ItemNumber.ToString();

                string[] contents = new string[7];
                contents[0] = "";
                contents[1] = item_number;
                contents[2] = item.SubItem;
                contents[3] = item.Details;
                contents[4] = item.Unit;
                contents[5] = item.Quantity;
                contents[6] = item.Comment;
                var lvi = new ListViewItem(contents, -1)
                {
                    Tag = item,
                    Checked = isChecked 
                };

                if (font != null)
                    lvi.Font = font;
                 
                return lvi;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            } 
        }

        //public ListViewItem[] ListViewItems(Section_Model section, Section_Model proj_section)
        //{
        //    try
        //    {
        //        ListViewItem[] items = LoadSectionItems(section, proj_section);

        //        if (section.Children.Count > 0)
        //        {
        //            var itemsList = items.ToList();
        //            foreach (var child_item in section.Children)
        //            {
        //                var child_listview_item = CreateListViewItem(child_item, false,
        //                            new Font("Microsoft Sans Serif", 8, FontStyle.Underline));
        //                if (child_listview_item != null)
        //                    itemsList.Add(child_listview_item);

        //                ListViewItem[] child_items = LoadItemGroup_Children(child_item, proj_section);
        //                itemsList.AddRange(child_items.ToList());
        //            }
        //            items = itemsList.ToArray();
        //        }

        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHelper.HandleException(ex);
        //        return null;
        //    }
        //}

        //private static ListViewItem[] LoadSectionItems(Section_Model master_section, Section_Model proj_section)
        //{
        //    try
        //    {
        //        ListViewItem[] items = new ListViewItem[master_section.Items.Count];
        //        var cnt = 0;
        //        foreach (var item in master_section.Items)
        //        {
        //            var isChecked = false;

        //            if (proj_section?.Items != null)
        //            {
        //                var proj_item = proj_section.Items.Find(i => i.ItemNumber == item.ItemNumber);
        //                if (proj_item != null)
        //                    isChecked = proj_item.Selected;
        //            }

        //            ListViewItem lvi = CreateListViewItem(item, isChecked);

        //            items[cnt] = lvi;
        //            cnt += 1;
        //        }
        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHelper.HandleException(ex);
        //        return null;
        //    }
        //}

        //private static ListViewItem[] LoadItemGroup_Children(Item_Model list_group_parent, Section_Model proj_section)
        //{
        //    try
        //    {
        //        ListViewItem[] items = new ListViewItem[list_group_parent.Children.Count];
        //        var cnt = 0;
        //        foreach (var item in list_group_parent.Children)
        //        {
        //            var isChecked = false;

        //            if (proj_section?.Items != null)
        //            {
        //                var proj_item = proj_section.Items.Find(i => i.ItemNumber == item.ItemNumber);
        //                if (proj_item != null)
        //                    isChecked = proj_item.Selected;
        //            }

        //            ListViewItem lvi = CreateListViewItem(item, isChecked);

        //            items[cnt] = lvi;
        //            cnt += 1;
        //        }
        //        return items;
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHelper.HandleException(ex);
        //        return null;
        //    }
        //}

    }
}
