using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Controller
{
    public class Populate_NavPages_Controller
    {

        public void Load_Sections_Into_HeaderGroups(
            SeparablePortion_Model separable_portion, ref Panel panel)
        {
            try
            {
                for (int cnt = separable_portion.Sections.Count - 1; cnt >= 0; cnt--)
                {
                    Section_Model section = separable_portion.Sections[cnt]; 

                    var headerGroup = new HeaderGroup_View().HeaderGroup(section);
                    if (headerGroup == null) continue;

                    panel.Controls.Add(headerGroup);
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }

        //public void Load_Sections_Into_HeaderGroups(MasterSchedule_Workbook_Model template,
        //    SeparablePortion_Model separable_portion, ref Panel panel)
        //{
        //    try
        //    {
        //        for (int cnt = template.Sections.Count - 1; cnt >= 0; cnt--)
        //        {
        //            Section_Model section = template.Sections[cnt];

        //            Section_Model proj_section = null;

        //            if (separable_portion != null)
        //                proj_section = separable_portion.Sections.Find(
        //                            s => s.Section_Name == section.Section_Name && 
        //                            s.Section_Number == section.Section_Number);

        //            var headerGroup = new HeaderGroup_View().HeaderGroup(section, proj_section);
        //            if (headerGroup == null) continue; 

        //            panel.Controls.Add(headerGroup);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        ExceptionHelper.HandleException(ex); 
        //    }
        //}


    }
}
