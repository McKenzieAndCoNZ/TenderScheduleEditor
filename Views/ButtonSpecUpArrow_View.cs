using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class ButtonSpecUpArrow_View
    {
        public ButtonSpecHeaderGroup ButtonSpecUpArrow()
        {
            var buttonSpecArrowUp = new ButtonSpecHeaderGroup
            {
                ColorMap = System.Drawing.Color.Black,
                Type = PaletteButtonSpecStyle.ArrowUp,
                UniqueName = Guid.NewGuid().ToString("N")
            };
            return buttonSpecArrowUp;
        }
    }
}
