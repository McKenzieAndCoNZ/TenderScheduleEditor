using System;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Helper
{
    internal class ExceptionHelper
    {
        public static void HandleException(Exception ex)
        {
            MessageBox.Show(ex.ToString());
        }
    }
}