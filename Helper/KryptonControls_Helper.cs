using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using ComponentFactory.Krypton.Toolkit;
using Microsoft.VisualBasic;
using PaymentsScheduleTemplateCreator.ViewModels;

namespace PaymentsScheduleTemplateCreator.Helper
{
    public class KryptonControls_Helper
    {
        public KryptonContextMenu CreateContextMenu()
        {
            try
            {
                KryptonContextMenu menu = new KryptonContextMenu();
                return menu;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }

        public KryptonContextMenuCheckBox CreateContextMenuCheckbox(KryptonCheckboxSettings_ViewModel settings)
        {
            try
            {
                KryptonContextMenuCheckBox ckbx = new KryptonContextMenuCheckBox()
                {
                    Checked = settings.Checked,
                    Image = settings.Image,
                    Text = settings.Text
                };

                return ckbx;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }

        public KryptonContextMenuHeading CreateKryptonContextMenuHeading(KryptonContextHeaderMenuSettings_ViewModel settings)
        {
            try
            {
                KryptonContextMenuHeading mnuHeading = new KryptonContextMenuHeading()
                {
                    Image = settings.HeaderImage,
                    Text = settings.HeaderText
                };

                return mnuHeading;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);

                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }

        public KryptonContextMenuItem CreateKryptonContextMenuItem(KryptonContextMenuSettings_ViewModel settings)
        {
            try
            {
                KryptonContextMenuItem mnuItem = new KryptonContextMenuItem()
                {
                    Image = settings.MenuImage,
                    Text = settings.MenuText
                };

                return mnuItem;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);

                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }
    }

}
