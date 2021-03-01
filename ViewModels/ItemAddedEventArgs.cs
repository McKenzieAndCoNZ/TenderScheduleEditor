using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.ViewModels
{
    public class ItemAddedEventArgs: EventArgs
    {
        public string Item_No { get; set; }
        public string SubItem_No { get; set; }
        public string Description { get; set; }
        public string Units { get; set; }
        public string Qty { get; set; }
        public string Comments { get; set; }
        public ListView Parent_ListView { get; set; }
    }
}
