using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
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

namespace PaymentsScheduleTemplateCreator.Forms.FrmInfo
{
    public partial class FrmInfo : KryptonForm
    {
        public FrmInfo()
        {
            InitializeComponent();
        }

        private void FrmInfo_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void Load_Form()
        { 
            try
            {
                LblCompany.Text = "McKenzie & Co";

                if (MainForms.Project != null)
                {
                    LblProjectName.Text = MainForms.Project.ProjectName;

                    if (!Directory.Exists(Path.GetDirectoryName(MainForms.Project.Project_FullPath))) return;

                    LblProjetPath.Text = MainForms.Project.Project_FullPath;
                    LblProjetPath.Tag = Path.GetDirectoryName(MainForms.Project.Project_FullPath);
                    LblProjetPath.Text = FormatProjectFullPath(MainForms.Project.Project_FullPath);

                    LblCreated.Text = MainForms.Project?.CreateDate.ToString("dd-MM-yy");
                    LblCreatedBy.Text = MainForms.Project?.CreatedBy;
                    LblLastModified.Text = File.GetLastWriteTime(
                                    MainForms.Project?.Project_FullPath).ToString("dd-MM-yy");
                    LblLastUpdatedBy.Text = MainForms.Project.LastEditedBy;
                    int size = Convert.ToInt32( new FileInfo(MainForms.Project.Project_FullPath)?.Length * .001);
                    LblNoOfLots.Text = size.ToString() + " KB";
                    LblTemplate.Text = MainForms.Project.MasterSchedule.Version;
                    LblTitle.Text = MainForms.Project.ProjectName;
                    CboStatus.Text = MainForms.Project.Status;
                    foreach (var tag in MainForms.Project.Tags)
                    {
                        TxtTags.Text += tag;
                        if (tag != MainForms.Project.Tags[MainForms.Project.Tags.Count - 1])
                            TxtTags.Text += ";";
                    }
                }
                 
                CreateProjectPathContextMenu();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private string FormatProjectFullPath(string projectName)
        { 
            try
            {
                string formatted_path = Path.GetDirectoryName(projectName);
                formatted_path = formatted_path.Replace("\\", " >> ");
                return formatted_path;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return string.Empty;
            }
        }

        private void CreateProjectPathContextMenu()
        {
            try
            {
                var createCntxMnu = new KryptonControls_Helper();
                var contextMenu = createCntxMnu.CreateContextMenu();

                LblProjetPath.KryptonContextMenu = contextMenu;

                KryptonContextMenuItems menuItems = new KryptonContextMenuItems();
                contextMenu.Items.Add(menuItems);

                KryptonContextMenuItem menuItem = null;

                menuItem = createCntxMnu.CreateKryptonContextMenuItem(new KryptonContextMenuSettings_ViewModel() { MenuText = "Copy link to clipboard" });

                if (menuItem != null)
                {
                    menuItem.Click += MenuItem_Click;
                    menuItems.Items.Add(menuItem);
                }

                menuItem = createCntxMnu.CreateKryptonContextMenuItem(new KryptonContextMenuSettings_ViewModel() { MenuText = "Open file location" });

                if (menuItem != null)
                {
                    menuItem.Click += MenuItem_Click;
                    menuItems.Items.Add(menuItem);
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }

        private void MenuItem_Click(object sender, EventArgs e)
        { 
            try
            {
                if ((sender as KryptonContextMenuItem).Text == "Open file location")
                    Process.Start(LblProjetPath.Tag as string);

                if ((sender as KryptonContextMenuItem).Text == "Copy link to clipboard")
                    System.Windows.Forms.Clipboard.SetText(LblProjetPath.Tag as string); 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

    }
}
