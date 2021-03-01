using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class KryptonContextHeaderMenuSettings_ViewModel
    {
        public Image HeaderImage { get; set; }
        public string HeaderText { get; set; } = string.Empty;
        public string ExtraText { get; set; } = string.Empty;
    }
}
