using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmTest
{
    public partial class FrmTest : KryptonForm // Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }

        private void kryptonHeaderGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kryptonHeaderGroup1_DoubleClick(object sender, EventArgs e)
        {
            this.kryptonHeaderGroup1.Collapsed = !this.kryptonHeaderGroup1.Collapsed;
        }
    }
}
