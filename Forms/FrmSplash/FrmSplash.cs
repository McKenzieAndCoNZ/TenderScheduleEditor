using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PaymentsScheduleTemplateCreator.Models.MasterSchedule_Workbook_Model;

namespace PaymentsScheduleTemplateCreator.Forms.FrmSplash
{
    public partial class FrmSplash : KryptonForm
    {
        private Stopwatch _timer = null;
        private const int MINIMUM_SPLASH_TIME = 3000; // Miliseconds
        private const int SPLASH_FADE_TIME = 500;     // Miliseconds


        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            Version version = Assembly.GetEntryAssembly().GetName().Version;
            LblVersion.Text += " - " + version.Major.ToString() + "." + version.Minor.ToString();

            progressBar1.MarqueeAnimationSpeed = 100;
            progressBar1.Style = ProgressBarStyle.Continuous;
            progressBar1.Show();
        }
       
        private async void FrmSplash_Shown(object sender, EventArgs e)
        {  // Step 2 - Start a stop watch
            _timer = new Stopwatch();
            _timer.Start();

            if (!File.Exists(Properties.Settings.Default.MasterScheduleFullPath))
            {
                var master_schedule_form = new FrmMasterSchedule.FrmMasterSchedule();
                master_schedule_form.ShowDialog();
            }

            if (File.Exists(Properties.Settings.Default.MasterScheduleFullPath))
            {
                var file_name = Path.GetFileNameWithoutExtension(Properties.Settings.Default.MasterScheduleFullPath);
                LblMessage.Text =  "Workbook " + file_name + " Found ...";
                
                // does the master schedule file exists
                var schedule_file_path = new FilePath_Helper().MasterScheduleFile_FullPath();

                if (string.IsNullOrEmpty(schedule_file_path))
                {
                    LblMessage.Text = "Master Schedule File Has Not Been Created ...";

                    // put the data from the workbook
                    // place it in MainForms.MasterSchedule
                    var init_task = await new MasterSchedule_Controller().Create_MasterSchedule_File();

                    LblMessage.Text = "Master Schedule File Created From Workbook ...";

                    if (init_task)
                       // check for file again ...
                        schedule_file_path = new FilePath_Helper().MasterScheduleFile_FullPath();

                    if (File.Exists(schedule_file_path))
                        MainForms.MasterSchedule = new MasterSchedule_Controller().Load_MasterSchedule_From_File();
                }
                else 
                {// read the data from the master schedule file and place in MainForms.MasterSchedule
                    MainForms.MasterSchedule = new MasterSchedule_Controller().Load_MasterSchedule_From_File();
                }
                
                if (! File.Exists(schedule_file_path))
                {
                    LblMessage.Text = "Error: Master Schedule File Was NOT Created ...";
                }
            }

            _timer.Stop();
            int remainingTimeToShowSplash = MINIMUM_SPLASH_TIME - (int)_timer.ElapsedMilliseconds;
            if (remainingTimeToShowSplash > 0)
                Thread.Sleep(remainingTimeToShowSplash);
             
            MainForms.OpenProject_Form.Show();
            MainForms.SplashForm.Visible = false;
        } 
         
        private bool Template_Exists()
        {
            try
            {
                if (!File.Exists(Properties.Settings.Default.MasterScheduleFullPath))
                {

                }
                return true;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }
    }
}
