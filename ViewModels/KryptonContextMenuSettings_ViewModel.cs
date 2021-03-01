using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class KryptonContextMenuSettings_ViewModel
    {
        public Image MenuImage { get; set; }
        public string MenuText { get; set; } = string.Empty;
        public string ExtraText { get; set; } = string.Empty;
        public EventHandler MenuClickDelegate { get; set; } = null;
    }
}
