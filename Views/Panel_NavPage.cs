using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class Panel_NavPage
    {
        public Panel PanelScroll(SeparablePortion_Model separable_portion)
        {
            try
            {
                var panelScroll = new Panel
                {
                    AutoScroll = true,
                    Dock = System.Windows.Forms.DockStyle.Fill,
                    Location = new System.Drawing.Point(0, 0),
                    Name = "PnlScroll_" + Guid.NewGuid().ToString("N"),
                    Size = new System.Drawing.Size(603, 498),
                    TabIndex = 1
                }; 

                var controller = new Populate_NavPages_Controller();
                controller.Load_Sections_Into_HeaderGroups(separable_portion, ref panelScroll);

                return panelScroll;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }
    }
}
