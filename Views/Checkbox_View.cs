using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class Checkbox_View
    {
        public CheckBox ChkBox()
        {
            var chkView = new CheckBox
            {
                AutoSize = true,
                Location = new System.Drawing.Point(4, 4),
                Name = Guid.NewGuid().ToString("N"),
                Size = new System.Drawing.Size(70, 17),
                TabIndex = 0,
                Text = "Select All",
                UseVisualStyleBackColor = true
            };
            return chkView;
        } 
    }
}
