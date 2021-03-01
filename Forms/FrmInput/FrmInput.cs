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

namespace PaymentsScheduleTemplateCreator.Forms.FrmInput
{
    public partial class FrmInput : KryptonForm
    {
        public FrmInput()
        {
            InitializeComponent();
        }
        public FrmInput(string title ="", string message = "", string default_text = "")
        {
            InitializeComponent();
            Text = title;
            LblMessage.Text = message;
            TxtInput.Text = default_text;
        }

        private void FrmInput_Load(object sender, EventArgs e) { }

        private void BtnOk_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string RetrieveUserResponse()
        {
            return TxtInput.Text;
        }
    }
}
