using PaymentsScheduleTemplateCreator.Forms.FrmAddSectionItem;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class CheckListView_View
    {

        public ListView CheckedListView(Section_Model section)
        {
            var listView = new ListView
            {
                CheckBoxes = true
            };

            listView.Columns.AddRange(new SectionColumns_View().SectionColumns());
            listView.Dock = DockStyle.Top;
            listView.HideSelection = false;
            listView.Items.AddRange(new ListViewItems_View().ListViewItems(section));
             
            if (section.Section_Name == "EARTHWORKS")
            {
                var st = string.Empty;
            }

            var lvi_heigth = 13;
            var lv_height = (section.Total_Items) * lvi_heigth;

            listView.Location = new System.Drawing.Point(0, 24);
            listView.Name = "LstViewSection" + section.Section_Number.ToString();
            listView.Size = new System.Drawing.Size(685, lv_height);
            listView.TabIndex = 2;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.FullRowSelect = true;
            listView.ContextMenuStrip = new CMS_ListView_View().ContextMenu_ListView();
            listView.ContextMenuStrip.Tag = listView;

            listView.ContextMenuStrip.Items[0].Click += CheckListView_View_Click;

            listView.MouseEnter += delegate
            { listView.Parent?.Focus(); };

            return listView;
        }

        FrmAddSectionItem _addSectionForm = null;
        private void CheckListView_View_Click(object sender, EventArgs e)
        {
            try
            {
                var tsmi = sender as ToolStripMenuItem;
                var cmsListView = tsmi.GetCurrentParent() as ContextMenuStrip;
                if (cmsListView == null) return;

                var lstview = cmsListView.Tag as ListView;
                if (lstview == null) return;
                if (lstview.SelectedItems.Count == 0) return;
                var row_index = lstview.SelectedItems[0].Index;

                _addSectionForm = new FrmAddSectionItem();
                _addSectionForm.Tag = lstview;

                _addSectionForm.ItemAdded += Section_ItemAdded;

                _addSectionForm.ShowDialog(); 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        } 

        private void Section_ItemAdded(object sender, ItemAddedEventArgs e)
        { 
            try
            {
                var form = sender as Form;
                var lstView = form.Tag as ListView;
                if (lstView == null) return;
                if (lstView.SelectedItems == null || lstView.SelectedItems.Count == 0) return;
               
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(e.Item_No);
                lvi.SubItems.Add(e.SubItem_No);
                lvi.SubItems.Add(e.Description);
                lvi.SubItems.Add(e.Units);
                lvi.SubItems.Add(e.Qty);
                lvi.SubItems.Add(e.Comments);

                if (lstView.Items.Count >= lstView.SelectedItems[0].Index + 1)
                {
                    lstView.Items.Insert(lstView.SelectedItems[0].Index + 1, lvi);
                }
                else
                    lstView.Items.Add(lvi);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }
         
    }
}
