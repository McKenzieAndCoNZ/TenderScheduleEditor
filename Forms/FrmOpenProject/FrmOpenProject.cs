using BrightIdeasSoftware;
using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmOpenProject
{
    public partial class FrmOpenProject : KryptonForm
    {
        public FrmOpenProject()
        {
            InitializeComponent();
        }

        private void FrmOpenProject_Load(object sender, EventArgs e)
        {
            AdjustListViewHieght(65);

            SetUpColumns();

            LoadAllProjectsToRecentsList();

            ListView_Helper.EnableDoubleBuffer(this.LstRecentProjects);
        }
         
        private void BtnNewProject_Click(object sender, EventArgs e)
        {
            var newPrjForm = new FrmNewProject.FrmNewProject();
            newPrjForm.ShowDialog();
            BtnClose_Click(sender, e);
        }

        private void BtnOpenProject_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Filter = "Project|*.pymt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    if (new Open_Project_Controller().OpenProject(openFileDialog1.FileName))
                        BtnClose_Click(sender, e);
                }
            }
        } 

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private List<ProjectFile_ViewModel> _recentPrjs { get; set; } = null;

        private List<ProjectFile_ViewModel> FindProjectDataTable()
        {
            try
            {
                List<ProjectFile_ViewModel> prjDataList = new List<ProjectFile_ViewModel>();
                foreach (ListViewItem item in LstRecentProjects.SelectedItems)
                {
                    if (!(item is OLVListItem))
                        continue;

                    if (!(((OLVListItem)item).RowObject is ProjectFile_ViewModel))
                        return null;

                    ProjectFile_ViewModel prjData = (ProjectFile_ViewModel)((OLVListItem)item).RowObject;

                    if (prjData != null)
                        prjDataList.Add(prjData);
                }

                return prjDataList;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);

                return null;
            }
        }
         
        private void LoadObjetsToList()
        {
            this.LstRecentProjects.BeginUpdate();
            this.LstRecentProjects.ClearObjects();
            this.LstRecentProjects.SetObjects(_recentPrjs);
            this.LstRecentProjects.EndUpdate();
        }
        private void LoadAllProjectsToRecentsList()
        {
            try
            {
                _recentPrjs =new Open_AllProjects_Controller().ReturnAllProjects(); 
                if (_recentPrjs == null || _recentPrjs.Count == 0)
                    return;
                this.LstRecentProjects.SetObjects(_recentPrjs);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        }

        private void LstRecentProjects_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                OLVListItem olvi = ((ObjectListView)sender).SelectedItem;
                ProjectFile_ViewModel ptd = (ProjectFile_ViewModel)olvi.RowObject;
                OpenRecentProject(ptd);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }
        private void OpenRecentProject(ProjectFile_ViewModel ptd)
        {
            try
            {
                if (ptd == null)
                    return;

                // Open Project 
                if (new Open_Project_Controller().OpenProject(ptd.Project_FullPath))
                    this.Close();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }
        } 

        private void TsmiOpen_Click(object sender, EventArgs e)
        {
            var row = LstRecentProjects.SelectedObject as ProjectFile_ViewModel;
            if (row == null) return;
            OpenRecentProject(row);
        }

        private void TsmiCopyPath_Click(object sender, EventArgs e)
        { 
            var row = LstRecentProjects.SelectedObject as ProjectFile_ViewModel;
            if (row == null) return;
            Clipboard.SetText(((ProjectFile_ViewModel)row).Project_FullPath);
        }

        private void TsmiRemove_Click(object sender, EventArgs e)
        {
            try
            {
                var proj = LstRecentProjects.SelectedObject as ProjectFile_ViewModel;
                if (proj == null) return;
                proj.DisplayInRecentList = false;
                proj.WriteToFile(new Save_ProjectFile_Helper(proj));
                LoadAllProjectsToRecentsList();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            } 
        }

        private void TsmiShowAllProjects_Click(object sender, EventArgs e)
        {
            try
            {
                var recentPrjs = new Open_AllProjects_Controller().ReturnAllProjects();
                foreach (var proj in recentPrjs)
                {
                    proj.DisplayInRecentList = true;
                    proj.WriteToFile(new Save_ProjectFile_Helper(proj));
                }
                LoadAllProjectsToRecentsList();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        private void FrmOpenProject_ResizeEnd(object sender, EventArgs e)
        {
            try
            {
                var distance = this.Width - (BtnClose.Width + 90);

                if (distance > 3)
                    splitContainer1.SplitterDistance = distance;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void FrmOpenProject_SizeChanged(object sender, EventArgs e)
        {
            FrmOpenProject_ResizeEnd(sender, e);
        }
    }
}
