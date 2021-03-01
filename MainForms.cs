using PaymentsScheduleTemplateCreator.Forms.FrmOpenProject;
using PaymentsScheduleTemplateCreator.Forms.FrmSplash;
using PaymentsScheduleTemplateCreator.Forms.FrmWB_CRUD;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentsScheduleTemplateCreator
{
    public class MainForms
    {  
        public static ViewModels.MasterSchedule_ViewModel MasterSchedule { get; set; } 

        public static ProjectFile_ViewModel Project { get; set; }

        private static FrmWB_CRUD _mainform = null;
        public static FrmWB_CRUD WB_CRUDForm
        {
            get
            {
                if (_mainform == null)
                    _mainform = new FrmWB_CRUD();
                return _mainform;
            }
        }

        //=======================================================


        private static FrmOpenProject _openProjectform = null;
        public static FrmOpenProject OpenProject_Form
        {
            get
            {
                if (_openProjectform == null)
                    _openProjectform = new FrmOpenProject();
                return _openProjectform;
            }
        }
        //=======================================================

        private static FrmSplash _splashform = null;
        public static FrmSplash SplashForm
        {
            get
            {
                if (_splashform == null)
                    _splashform = new FrmSplash();
                return _splashform;
            }
        }

        public static FormPosition_Model FindScreenDisplayData(string name)
        {
            try
            {
                System.Windows.Forms.Screen[] screens = System.Windows.Forms.Screen.AllScreens;

                FormPosition_Model form_position = null;// settings.FormLocationSettings?.Forms_Locations?.Find(s => s.FormName == name);

                Point location = new Point(0, 0);
                Size form_size = new Size(690, 665);
                if (form_position != null)
                {
                    location = form_position.Location;
                    form_size = form_position.FormSize;
                }

                Rectangle rect = new Rectangle(location.X, location.Y, form_size.Width, form_size.Height);

                bool screenLocationValid = false;

                var screen_data = new FormPosition_Model();
                foreach (System.Windows.Forms.Screen screen in screens)
                {
                    if (screen.Bounds.IntersectsWith(rect))
                    {
                        screen_data.Location = new Point(rect.X, rect.Y);
                        screen_data.FormSize = new Size(form_size.Width, form_size.Height);
                        screenLocationValid = true;
                        return screen_data;
                    }
                }

                if (!screenLocationValid)
                {
                    foreach (System.Windows.Forms.Screen screen in screens)
                    {
                        if (screen.Primary)
                        {
                            rect = System.Windows.Forms.Screen.FromPoint(screen_data.Location).WorkingArea;

                            var x = rect.Left + (rect.Width - form_size.Width) / 2;
                            var y = rect.Top + (rect.Height - form_size.Height) / 2;

                            screen_data.Location = new Point(x, y);
                            screen_data.FormSize = new Size(form_size.Width, form_size.Height);

                            return screen_data;
                        }
                    }
                }

                return null/* TODO Change to default(_) if this is not a reference type */;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }



        public static void SaveFormPosition(string name, Point location, Size size)
        {
            try
            {
                FormPosition_Model form_position = null;

                if (form_position == null)
                {
                    form_position = new FormPosition_Model
                    {
                        FormName = name,
                        FormSize = size,
                        Location = location
                    }; 
                }

                form_position.FormName = name;
                form_position.Location = location;
                form_position.FormSize = size;

               // SettingsFile.BBSettingsFile.SaveFormSettings(CouncilSettings(My.Settings.CouncilName));
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }
    }
}
