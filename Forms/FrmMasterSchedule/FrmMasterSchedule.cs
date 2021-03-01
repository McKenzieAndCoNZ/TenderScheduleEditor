using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmMasterSchedule
{
    public partial class FrmMasterSchedule : KryptonForm
    {
        private FileSystemWatcher _watcher;

        public FrmMasterSchedule()
        {
            InitializeComponent();
        }

        private void FrmMasterSchedule_Load(object sender, EventArgs e)
        {
            try
            {
                _watcher = new FileSystemWatcher(Path.GetDirectoryName(@Properties.Settings.Default.MasterScheduleFullPath));
                _watcher.Changed +=
                    new FileSystemEventHandler(Watcher_Changed);
                _watcher.EnableRaisingEvents = true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }

        private void FrmMasterSchedule_Shown(object sender, EventArgs e)
        {  
            var path_exists = File.Exists(@Properties.Settings.Default.MasterScheduleFullPath);
            SetLnkLableVisible(!path_exists); 
        }

        private async void BtnNavToMasterSchedule_Click(object sender, EventArgs e)
        {
            DialogResult results = DialogResult.OK;
            if (LnkMasterSchedule.Visible)
            {
                var message = "Click The 'Cancel' Button to Return and Clink on the Link to Download The File From Synergy \r\n \r\n" +
                    "Click The 'OK' Button To Navigate to The Master Schedule Workbook.";
                results = MessageBox.Show(message, "Download Master Schedule",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

            if (results == DialogResult.OK)
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    SetLnkLableVisible(false);
                    TxtMasterScheduleFullPath.Text = openFileDialog1.FileName;
                    Properties.Settings.Default.MasterScheduleFullPath = openFileDialog1.FileName;
                    Properties.Settings.Default.Save();

                    await new MasterSchedule_Controller().Create_MasterSchedule_File();
                }
        }


        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("synergy12d://MCKSQL01/?File=1431138_e5ff2d2c_516f_47f3_8c27_9268839db6c9");
        }

        private async void Watcher_Changed(object sender, FileSystemEventArgs e)
        {
            if (File.Exists(Properties.Settings.Default.MasterScheduleFullPath))
            {
                SetLnkLableVisible(false);

                TxtMasterScheduleFullPath.Invoke((MethodInvoker)(() => TxtMasterScheduleFullPath.Text =
                Properties.Settings.Default.MasterScheduleFullPath));

                await new MasterSchedule_Controller().Create_MasterSchedule_File();
            }
            else
                TxtMasterScheduleFullPath.Invoke((MethodInvoker)(() => TxtMasterScheduleFullPath.Text = ""));
        }

        private void SetLnkLableVisible(bool visible)
        { 
            //LnkMasterSchedule.Invoke((MethodInvoker)delegate {
            //    // Running on the UI thread
            //    LnkMasterSchedule.Visible = visible;
            //});
            //LblClickLink.Invoke((MethodInvoker)delegate {
            //    // Running on the UI thread
            //    LblClickLink.Visible = visible;
            //}); 
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
