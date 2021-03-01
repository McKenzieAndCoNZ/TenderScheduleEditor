using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class KryptonCheckboxSettings_ViewModel
    {
        public bool Checked { get; set; } = true;
        public Size CheckboxSize { get; set; }
        public Image Image { get; set; }
        public string Text { get; set; } = string.Empty;
    }
}
