using ComponentFactory.Krypton.Navigator;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class NavPage_View
    {
        public KryptonPage NavPage(string page_name, 
                                    SeparablePortion_Model separable_portion)
        { 
            try
            {
                var page = new KryptonPage
                {
                    AutoHiddenSlideSize = new System.Drawing.Size(200, 200),
                    Flags = 65534,
                    LastVisibleSet = true,
                    MinimumSize = new System.Drawing.Size(50, 50),
                    Name = "PageSP_" + Guid.NewGuid().ToString("N"),
                    Size = new System.Drawing.Size(603, 498),
                    Text = page_name,
                    ToolTipTitle = "Select the Items To Include In This Separable Portion",
                    UniqueName = Guid.NewGuid().ToString("N") 
                };
                page.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
                    new ButtonSpecAny_ViewModel().BtnSpec_EditName()});
                page.Controls.Add(new Panel_NavPage().PanelScroll(separable_portion)); 

                return page;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }
    }
}
