using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class ButtonSpecAny_ViewModel
    {
        public ButtonSpecAny BtnSpec_EditName()
        {
            var btn = new ButtonSpecAny
            {
                Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.edit_16,
                ImageTransparentColor = System.Drawing.SystemColors.Control, 
                Style = PaletteButtonStyle.Custom2,
                Type = PaletteButtonSpecStyle.FormMin,
                UniqueName = Guid.NewGuid().ToString("N")
            };
            return btn;
        }
    }
}
