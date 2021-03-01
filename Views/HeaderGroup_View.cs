using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class HeaderGroup_View
    {
        private ListViewItem li; 
        private string subItemText;
        private int subItemSelected = 0;
        private TextBox editBox = new TextBox(); 

        public KryptonHeaderGroup HeaderGroup(Section_Model section)
        {
            try
            {
                var headerGroup = new KryptonHeaderGroup
                {
                    AutoSize = true,
                    Dock = System.Windows.Forms.DockStyle.Top,
                    HeaderVisibleSecondary = false,
                    Margin = new Padding(1),
                    Name = Guid.NewGuid().ToString("N"),
                    Tag = section
                };

                headerGroup.ButtonSpecs.AddRange(new ButtonSpecHeaderGroup[]
                { new ButtonSpecUpArrow_View().ButtonSpecUpArrow()});

                var listView = new CheckListView_View().CheckedListView(section);
                if (listView != null)
                {
                    editBox.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);
                    editBox.Visible = false;

                    listView.Controls.Add(editBox);
                    headerGroup.Panel.Controls.Add(listView);

                    listView.MouseDown += new MouseEventHandler(this.ListView_MouseDown);
                    listView.MouseDoubleClick += new MouseEventHandler(this.ListViewItem_MouseDoubleClick);
                    listView.MouseWheel += new MouseEventHandler(control_MouseEnter);
                    listView.SelectedIndexChanged += ListView_SelectedIndexChanged;
                    listView.ColumnClick += ListView_ColumnClick;
                    listView.ItemChecked += ListView_ItemChecked;
                }

                bool select_all = false;
                if (section?.Items != null)
                    select_all = section.Items.Exists(i => !i.Selected);
                var panel_checkbox = new PanelCheckbox_View().PanelCheckbox(headerGroup, select_all);
                if (panel_checkbox != null)
                {
                    headerGroup.Panel.Controls.Add(panel_checkbox);

                    for (int cnt = 0; cnt < panel_checkbox.Controls.Count; cnt++)
                    {
                        if (panel_checkbox.Controls[cnt] is CheckBox)
                        {
                            var chkBox = (CheckBox)panel_checkbox.Controls[cnt];

                            chkBox.CheckedChanged += new EventHandler(Checked_Changed);
                            break;
                        }
                    }
                } 

                headerGroup.TabIndex = 0;
                headerGroup.ValuesPrimary.Heading = section.Section_Number.ToString() +
                                                    " " + section.Section_Name;
                headerGroup.ValuesPrimary.Image = null;
                headerGroup.Collapsed = true;

                headerGroup.DoubleClick += new EventHandler(HeaderGroup_DoubleClick);
                headerGroup.CollapsedChanged += HeaderGroup_CollapsedChanged;

                return headerGroup;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }

        private void HeaderGroup_CollapsedChanged(object sender, EventArgs e)
        {
            try
            {
                var header_group = sender as KryptonHeaderGroup;

                var grpPanel = header_group.Controls[0] as KryptonGroupPanel;
                if (grpPanel == null) return;

                ListView listView = null;
                Panel pnlCheckbox = null;
                for (int cnt = 0; cnt < grpPanel.Controls.Count; cnt++)
                {
                    if (grpPanel.Controls[cnt] is ListView)
                        listView = grpPanel.Controls[cnt] as ListView;
                    if (grpPanel.Controls[cnt] is Panel)
                        pnlCheckbox = grpPanel.Controls[cnt] as Panel;
                }

                if (listView == null) return;

                int headerHeight = 24;
                int pnlHeight = 24;
                if (pnlCheckbox != null)
                    pnlHeight = pnlCheckbox.Height;
                 
                var lv_height = pnlHeight + headerHeight;

                foreach (ListViewItem lvi in listView.Items)
                {
                    lv_height += lvi.GetBounds(ItemBoundsPortion.Entire).Height;
                }
                listView.Size = new System.Drawing.Size(listView.Width, lv_height);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        private bool _prevent_item_checked_event = false;
        private bool _prevent_checked_change_event = false;

        /// <summary>
        /// This event is used to set the "Selected" property of the item 
        /// and to check or uncheck the parent item as required
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListView_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            try
            {
                if (_prevent_item_checked_event) return;
                var selected_item = e.Item.Tag as Item_ViewModel;
                if (!(selected_item is Item_ViewModel)) return;

                Section_Model selected_section = null;
                if ((selected_item.Parent is Section_Model))
                {
                    selected_section = ((Section_Model)selected_item.Parent);
                } 
                else if ((selected_item.Parent is Item_ViewModel))
                {
                    if (((Item_ViewModel)selected_item.Parent).Parent is Section_Model)
                    {
                        selected_section = ((Item_ViewModel)selected_item.Parent).Parent as Section_Model;
                    }
                }
 
                selected_item.Selected = e.Item.Checked;

                if (selected_item.Children.Count > 0)
                { 
                    if (!e.Item.Checked)
                        // this item has children therefore it is a Parent
                        // we MUST uncheck all children 
                        foreach (ListViewItem lv_item in e.Item.ListView.Items)
                        {
                            if (lv_item == null) continue;
                            var lv_Item_ViewModel = lv_item.Tag as Item_ViewModel;
                            if (lv_Item_ViewModel == null) continue;

                            var child_item = selected_item.Children.Find(ci => ci == lv_Item_ViewModel);
                            if (child_item == null) continue;
                             
                            lv_item.Checked = false;
                            child_item.Selected = false; 
                        } 
                }

                var parent_item = selected_item.Parent as Item_ViewModel;
                if (parent_item != null)
                {
                    if (selected_item.Selected)
                        parent_item.Selected = true;

                    SearchListForParent(e.Item.ListView.Items, e.Item.Checked,
                                            selected_item, parent_item);
                }

                var lstView = sender as ListView;
                var grpPanel = lstView.Parent as KryptonGroupPanel;
                SelectAll_Checkbox_Edit(grpPanel);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        private void SelectAll_Checkbox_Edit(KryptonGroupPanel grpPanel)
        {
            try
            {
                ListView lstView = null;// sender as ListView
                Panel pnlCheckBox = null;
         
                for (int cnt = 0; cnt < grpPanel.Controls.Count; cnt++)
                {
                    if (grpPanel.Controls[cnt] is ListView)
                        lstView = grpPanel.Controls[cnt] as ListView;
                    if (grpPanel.Controls[cnt] is Panel)
                        pnlCheckBox = grpPanel.Controls[cnt] as Panel;
                }
                var chkBox = pnlCheckBox.Controls[0] as CheckBox;

                var all_items_checked = true;
                foreach (ListViewItem lvi in lstView.Items)
                {
                    if (!lvi.Checked)
                    {
                        all_items_checked = false;
                        break;
                    }
                }
                _prevent_checked_change_event = !all_items_checked;
                if (_prevent_checked_change_event == false)
                {
                    var st = string.Empty;
                }
                chkBox.Checked = all_items_checked;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
            finally
            {
                _prevent_checked_change_event = false;
            }
        }

        private void SearchListForParent(ListViewItemCollection lstview_items, bool item_checked,
                                         Item_ViewModel selected_item, Item_ViewModel parent_item)
        { 
            try
            {  
                if (parent_item == null)
                    return;

                foreach (ListViewItem lv_item in lstview_items)
                {
                    if (lv_item == null) continue;
                    var lv_Item_ViewModel = lv_item.Tag as Item_ViewModel;

                    if (lv_Item_ViewModel == parent_item)
                    {
                        if (item_checked)
                        {   // we MUST check the parent
                          //  _prevent_item_checked_event = true;
                            lv_item.Checked = true;
                         //   _prevent_item_checked_event = false;
                        }
                        else
                        {   // this child item was unchecked 
                            // we can uncheck the parent if no 
                            // other sub items are selected
                          //  _prevent_item_checked_event = true;
                            lv_item.Checked = parent_item.Children.Exists(
                                        c => c != selected_item && c.Selected);
                         //   _prevent_item_checked_event = false;
                        }
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

         
        private void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            editBox.Visible = false;
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        { 
            editBox.Visible = false;
        }

        public void control_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Control)sender).Parent?.Focus();
          // ((Control)sender).Parent?.Parent?.Focus();
            //((Control)sender).Parent?.Parent?.Parent?.Focus();
           // ((Control)sender).Parent?.Parent?.Parent?.Parent?.Focus();
             //((Control)sender).Parent?.Parent?.Parent?.Parent?.Parent?.Focus();
        }


        public void ListViewItem_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var lstView = sender as ListView;

                li = lstView.GetItemAt(e.X, e.Y); 

                // Check the subitem clicked .
                //int nStart = X;
                int nStart = e.X;
                int spos = 0;
                int epos = lstView.Columns[0].Width;
                for (int i = 0; i < lstView.Columns.Count; i++)
                { 
                    if (nStart > spos && nStart < epos)
                    {
                        subItemSelected = i;
                        break;
                    }

                    spos = epos;
                    epos += lstView.Columns[i].Width;
                }
                if (subItemSelected < 5) return; 
                subItemText = li.SubItems[subItemSelected].Text;

                string colName = lstView.Columns[subItemSelected].Text;
                editBox.Size = new System.Drawing.Size(li.SubItems[subItemSelected].Bounds.Width, li.SubItems[subItemSelected].Bounds.Height);
                editBox.Location = new System.Drawing.Point(li.SubItems[subItemSelected].Bounds.X, 
                                                            li.SubItems[subItemSelected].Bounds.Y);
                editBox.Visible = true;
                editBox.Show();
                editBox.BringToFront();
                editBox.Text = subItemText;
                editBox.SelectAll();
                editBox.Focus();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            } 
        }

        public void ListView_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            editBox.Visible = false;
        }

        private void HeaderGroup_DoubleClick(object sender, EventArgs e)
        {
            if (!(sender is KryptonHeaderGroup)) return;
            var headerGroup = sender as KryptonHeaderGroup; 
            headerGroup.Collapsed = !headerGroup.Collapsed;
        }


        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var txtBox = sender as TextBox;
            if (e.KeyChar ==  (char)Keys.Enter)
            { 
                li.SubItems[subItemSelected].Text = txtBox.Text;
                txtBox.Text = "";
                txtBox.Visible = false;
                return;
            }
            else if (e.KeyChar == (char)Keys.ShiftKey)
            {
                li.SubItems[subItemSelected].Text = txtBox.Text;
                txtBox.Text = "";
                txtBox.Visible = false;
                return;
            }
            else if (e.KeyChar == (char)Keys.Escape)
            { 
                txtBox.Text = "";
                txtBox.Visible = false;
                return;
            }
        }

        public void Checked_Changed(object sender, EventArgs e)
        { 
            try
            {
                if (_prevent_checked_change_event) return;
                CheckBox cb = (CheckBox)sender;

                if (cb.Parent?.Parent?.Parent == null) return;

                if (!(cb.Parent.Parent.Parent is KryptonHeaderGroup)) return;

                KryptonHeaderGroup headergroup = (KryptonHeaderGroup)cb.Parent.Parent.Parent;

                for (int cnt = 0; cnt < headergroup.Controls.Count; cnt++)
                {
                    if (headergroup.Controls[cnt] is KryptonGroupPanel)
                    {
                        _prevent_item_checked_event = true;

                        var kgPnl = headergroup.Controls[cnt] as KryptonGroupPanel;
                        for (int pnt_cnt = 0; pnt_cnt < kgPnl.Controls.Count; pnt_cnt++)
                        {
                            if (kgPnl.Controls[pnt_cnt] is ListView)
                            {
                                var lv = (ListView)kgPnl.Controls[pnt_cnt];

                                foreach (ListViewItem lvi in lv.Items)
                                {
                                    lvi.Checked = cb.Checked;
                                    var item_model = lvi.Tag as Item_ViewModel;
                                    if (item_model == null) continue;
                                    item_model.Selected = lvi.Checked;
                                }
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
            finally
            { 
                _prevent_item_checked_event = false;
            }
        }
    }
}
