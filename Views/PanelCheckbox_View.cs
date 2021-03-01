using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class PanelCheckbox_View
    {
        public Panel PanelCheckbox(Control parent, bool isChecked)
        {
            try
            {
                var pnlCheckBox = new Panel
                {
                    BackColor = System.Drawing.Color.Transparent
                };
                pnlCheckBox.Tag = parent;
                var chkBox = new Checkbox_View().ChkBox();
                if (chkBox != null)
                {
                    chkBox.Checked = isChecked;
                    pnlCheckBox.Controls.Add(new Checkbox_View().ChkBox());
                }
                pnlCheckBox.Dock = DockStyle.Top;
                pnlCheckBox.Location = new System.Drawing.Point(0, 0);
                pnlCheckBox.Name = "Pnl1ChkBox";
                pnlCheckBox.Size = new System.Drawing.Size(685, 24);
                pnlCheckBox.TabIndex = 1; 

                return pnlCheckBox;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            } 
        } 
    }
}
