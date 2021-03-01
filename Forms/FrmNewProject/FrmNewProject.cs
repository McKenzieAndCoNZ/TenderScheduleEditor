using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmNewProject
{
    public partial class FrmNewProject : KryptonForm
    {
        public FrmNewProject()
        {
            InitializeComponent();
        }

        private void FrmNewProject_Load(object sender, EventArgs e)
        {
            if (Directory.Exists(Properties.Settings.Default.TenderScheduleWBPath))
                TxtProgressPaymentsWorkbookPath.Text = Properties.Settings.Default.TenderScheduleWBPath;

            TxtProgressPaymentsWorkbookPath.Focus();
        }

        private void BtnNavToProgressPaymentsWB_Click(object sender, EventArgs e)
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
                    TxtProgressPaymentsWorkbookPath.Text = folderBrowserDialog1.SelectedPath;
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(TxtProjectName.Text))
                {
                    MessageBox.Show("Please Enter a Project Name to Proceed.");
                    return;
                }

               var proj_data = new Create_NewProject_Controller().Create_Project(
                                                                    TxtProjectName.Text,
                                                                    TxtProgressPaymentsWorkbookPath.Text);
                proj_data.Comments = TxtComments.Text;
                proj_data.No_of_Lots = (int)NUDNoOfLots.Value;

                IWriter writer = new Save_ProjectFile_Helper(proj_data); 
                proj_data.WriteToFile(writer);

                MainForms.WB_CRUDForm.LoadProject(proj_data);
                MainForms.WB_CRUDForm.Show();
                Close();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }
    }
}
