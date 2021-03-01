using PaymentsScheduleTemplateCreator.Forms.FrmSplash;
using PaymentsScheduleTemplateCreator.Forms.FrmTest;
using PaymentsScheduleTemplateCreator.Forms.FrmWB_CRUD;
using Serilog;
using System;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Log.Logger = new LoggerConfiguration()
             .WriteTo.File("/PS_Logs/log -.txt", rollingInterval: RollingInterval.Day)
             .CreateLogger();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(MainForms.WB_CRUDForm);
           Application.Run(MainForms.SplashForm);
        }
    }
}
