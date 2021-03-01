using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class CMS_ListView_View
    {
        public ContextMenuStrip ContextMenu_ListView()
        {
            var cmsListView = new ContextMenuStrip
            {
                Name = "CmsListView_InsertRow",
                Size = new System.Drawing.Size(180, 22),
                Text = "Insert Row",
                Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, 
                                                                System.Drawing.GraphicsUnit.World) 
            }; 
            cmsListView.Items.AddRange(new ToolStripItem[] { CMSI_InsertRow_View() });
            return cmsListView;
        } 
        
        public ToolStripMenuItem CMSI_InsertRow_View()
        {
            var cmsi_InsertRow = new ToolStripMenuItem
            {
                Name = "CmsListView_InsertRow",
                Size = new System.Drawing.Size(180, 22),
                Text = "Insert Row"
            }; 
            return cmsi_InsertRow;
        }

    }
}
