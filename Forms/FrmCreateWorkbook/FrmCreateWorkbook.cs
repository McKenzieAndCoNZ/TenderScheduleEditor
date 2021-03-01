using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.IO;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmCreateWorkbook
{
    public partial class FrmCreateWorkbook : KryptonForm
    {
        public FrmCreateWorkbook()
        {
            InitializeComponent();
        }

        private void FrmCreateWorkbook_Load(object sender, EventArgs e)
        {
            TxtCurrentMonth.Text = DateTime.Now.ToString("MMM yy");

            if (!string.IsNullOrEmpty(MainForms.Project?.OutputDirectory))
                TxtWorkbookLocation.Text = MainForms.Project.OutputDirectory + "\\" +
                    MainForms.Project.ProjectName + ".xlsm";
        }

        private void BtnSpecNavToWorkbook_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialog1.Description = "Location to Store the New Progress Payments Workbook";
                // Show the FolderBrowserDialog. 
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    Properties.Settings.Default.TenderScheduleWBPath =
                        folderBrowserDialog1.SelectedPath;
                    Properties.Settings.Default.Save();
                    TxtWorkbookLocation.Text = folderBrowserDialog1.SelectedPath;
                }

            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void RdoUseCurrentMonth_CheckedChanged(object sender, EventArgs e)
        {
            TxtCurrentMonth.Enabled = RdoUseCurrentMonth.Checked;
        }

        private void RdoUseCustomMonth_CheckedChanged(object sender, EventArgs e)
        {
            DTPCustomMonth.Enabled = RdoUseCustomMonth.Checked;
        }

        private void BtnCreateWorkbook_Click(object sender, EventArgs e)
        {
            if (ValidateInformationProvided())
            {
                var monthly_claim_name = RdoUseCurrentMonth.Text;
                if (RdoUseCustomMonth.Checked)
                    monthly_claim_name = RdoUseCustomMonth.Text;

                var excel_engine = new Excel_Engine_Controller();
                excel_engine.Create_TenderSchedule_Workbook(TxtWorkbookLocation.Text, MainForms.Project, monthly_claim_name);
            }
        }

        private bool ValidateInformationProvided()
        {
            try
            {
                if (!Directory.Exists(TxtWorkbookLocation.Text))
                {
                    MessageBox.Show("Please Enter a Workbook Location to Proceed.");
                    return false;
                }
                

                if (!DateTime.TryParse(TxtCurrentMonth.Text, out var dtResults))
                {
                    MessageBox.Show("The Date For the Current Month Is Invalid.\r\n" +
                        "If This Continues Please Use The 'Custom Month' Date Control Instead.");
                    return false;
                } 

                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return false;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
