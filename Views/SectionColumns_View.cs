using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Views
{
    public class SectionColumns_View
    {
        public ColumnHeader[] SectionColumns()
        {
            ColumnHeader[] columns = new ColumnHeader[7];
            columns[0] = new ColumnHeader
            {
                Text = "",
                Width = 20
            };
            columns[1] = new ColumnHeader
            {
                Text = "Item",
                Width = 48
            };
            columns[2] = new ColumnHeader
            {
                Text = "SubItem",
                Width = 20
            };
            columns[3] = new ColumnHeader
            {
                Text = "Details",
                Width = 485
            };
            columns[4] = new ColumnHeader
            {
                Text = "Units",
                Width = 40
            };
            columns[5] = new ColumnHeader
            {
                Text = "Qty",
                Width = 40
            };
            columns[6] = new ColumnHeader
            {
                Text = "Comment",
                Width = 350
            };

            return columns;
        }
    }
}
