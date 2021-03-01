using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class ButtonSpecContext_View
    {
        public ButtonSpecHeaderGroup Context_HeaderGroup()
        {
            var buttonSpecContext = new ButtonSpecHeaderGroup
            {
                Checked = ButtonCheckState.Checked,
                Type = PaletteButtonSpecStyle.Context,
                UniqueName = Guid.NewGuid().ToString("N")
            };
            return buttonSpecContext;
        }
    }
}
