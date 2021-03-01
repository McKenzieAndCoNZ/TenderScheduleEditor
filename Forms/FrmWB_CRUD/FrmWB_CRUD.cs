using ComponentFactory.Krypton.Navigator;
using ComponentFactory.Krypton.Ribbon;
using ComponentFactory.Krypton.Toolkit;
using PaymentsScheduleTemplateCreator.Controller;
using PaymentsScheduleTemplateCreator.Helper;
using PaymentsScheduleTemplateCreator.Models;
using PaymentsScheduleTemplateCreator.ViewModels;
using PaymentsScheduleTemplateCreator.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace PaymentsScheduleTemplateCreator.Forms.FrmWB_CRUD
{
    public partial class FrmWB_CRUD : KryptonForm 
    { 
        public FrmWB_CRUD()
        {
            InitializeComponent();
        } 

        private void FrmWB_CRUD_Load(object sender, EventArgs e)
        {
            LoadQATButtonEvents();
            LoadFileMenuEvents();
            LoadRecentProjects();
        }

        private void FrmWB_CRUD_Shown(object sender, EventArgs e)
        {
            LoadProjectToNavigator();
        }

        private void LoadProjectToNavigator()
        {
            try
            {
                ShowLoadingCircle(true);

                _template = MainForms.MasterSchedule;

                // load project file and tick related items
                if (_proj_data != null)
                {
                    this.Text = Properties.Settings.Default.AppName + " [" + Path.GetFileNameWithoutExtension(_proj_data.Project_FullPath) + "]";
                    NavSepPortions.Pages.Clear();
                    foreach (var separablePortion in _proj_data.SeparablePortions)
                    {
                        AddPage(separablePortion);
                    }
                }

                ShowLoadingCircle(false);
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            } 
        }

        private void ShowLoadingCircle(bool show)
        { 
            PnlLoading.Visible = show;
            if (PnlLoading.Visible)
                PnlLoading.BringToFront();
        }

        public void LoadProject(ProjectFile_ViewModel project)
        {
            _proj_data = project;
        }
  
        private ProjectFile_ViewModel _proj_data { get; set; } = null;
        private Models.MasterSchedule_Workbook_Model _template { get; set; } = null;
   
        private void PnlScroll_MouseWheel(object sender, MouseEventArgs e)
        {
            PnlScroll.Focus();
        }
 

        private void BtnAddSP_Click(object sender, EventArgs e)
        {
            AddPage();
        }
          

        private void FrmWB_CRUD_Resize(object sender, EventArgs e)
        {
             
        } 

        private void BtnSpecAddPage_Click(object sender, EventArgs e)
        {
            AddPage();
        }

        private void AddPage(SeparablePortion_Model sepPortion = null)
        {
            var sep_portion_name = "Separable Portion " + (NavSepPortions.Pages.Count + 1).ToString();
            if (sepPortion != null)
                sep_portion_name = sepPortion.Name;

            var new_navPage = new NavPage_View();
            var page = new_navPage.NavPage(sep_portion_name, sepPortion);
            if (page != null)
            {
                if (sepPortion != null)
                    Check_ListViewItems_Matching_ProjectData(page, sepPortion);
                if (page.ButtonSpecs.Count > 0)
                    foreach (var btn in page.ButtonSpecs)
                        btn.KryptonContextMenu = KCMPage; 

                NavSepPortions.Pages.Add(page);
            }
                
        }

        private void Check_ListViewItems_Matching_ProjectData(
                                    KryptonPage page, SeparablePortion_Model sepPortion)
        {
            try
            {
                var pnlScroll = page.Controls[0] as Panel;
                if (pnlScroll == null) return; 

                for (int pnlCnt = 0; pnlCnt < pnlScroll.Controls.Count; pnlCnt++)
                {
                    var headerGroup = pnlScroll.Controls[pnlCnt] as KryptonHeaderGroup;
                    if (headerGroup == null) continue;

                    var master_section = headerGroup.Tag as Section_Model;
                    if (master_section == null) continue;

                    var section = sepPortion.Sections.Find(s => s.Section_Name == master_section.Section_Name && 
                                                           s.Section_Number == master_section.Section_Number);
                    if (section == null) continue;

                    Panel PnlCheck = null;
                    var item_not_checked = false;
                    for (int header_cnt = 0; header_cnt < headerGroup.Controls.Count; header_cnt++)
                    {
                        var lstView = headerGroup.Controls[header_cnt] as ListView;
                        
                        if (lstView == null)
                        {
                            var pnl = headerGroup.Controls[header_cnt] as Panel;
                            if (pnl != null)
                                PnlCheck = pnl;

                            continue;
                        }

                        foreach (ListViewItem lvi in lstView.Items)
                        {
                            var item = lvi.Tag as Item_Model;
                            if (item == null) continue;

                            var prj_item = section.Items.Find(i => i.ItemNumber == item.ItemNumber);
                            if (prj_item != null)
                                lvi.Checked = prj_item.Selected;

                            if (!lvi.Checked)
                                item_not_checked = true;
                        }
                    } 
                    if (PnlCheck != null)
                    {
                        // if all items are checked then check the checkbox in the panel
                        for (int chk_cnt = 0; chk_cnt < PnlCheck.Controls.Count; chk_cnt++)
                        {
                            var ckbox = PnlCheck.Controls[chk_cnt] as CheckBox;
                            if (ckbox == null) continue;
                            ckbox.Checked = !item_not_checked;
                        }
                    }   
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
            }   
        }

        private void MnuFileNew_Click(object sender, EventArgs e)
        {
            var newProjectForm = new FrmNewProject.FrmNewProject();
            newProjectForm.ShowDialog();

        }

        private void MnuFileOpen_Click(object sender, EventArgs e)
        {
            QatOpenFile_Click(sender, e);
        } 

        private void MnuView_ContractInfo_Click(object sender, EventArgs e)
        {
            QatContractInfo_Click(sender, e);
        }

        private void MnuFile_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MnuFile_Close_Click(sender,e);
        }
 
        public List<SeparablePortion_Model> Find_Checked_Items_For_All_SeparablePortions()
        {
            try
            {
                var ret_sep_portions = new List<SeparablePortion_Model>();
                foreach (var page in NavSepPortions.Pages)
                {
                    var sep_portion = new SeparablePortion_Model
                    {
                        Name = page.Text
                    };
                    ret_sep_portions.Add(sep_portion);
                    for (int ctrl_cnt = 0; ctrl_cnt < page.Controls.Count; ctrl_cnt++)
                    {
                        if (!(page.Controls[ctrl_cnt] is Panel))
                            continue;

                        var pnlScroll = page.Controls[ctrl_cnt] as Panel;
                        for (int cnt = 0; cnt < pnlScroll.Controls.Count; cnt++)
                        {
                            if (!(pnlScroll.Controls[cnt] is KryptonHeaderGroup))
                                continue;

                            var headergroup = pnlScroll.Controls[cnt] as KryptonHeaderGroup;
                            Section_Model section = null;

                            if (headergroup.Tag is Section_Model)
                                section = headergroup.Tag as Section_Model;

                            var ret_section = new Section_Model
                            {
                                Section_Name = section.Section_Name,
                                Section_Number = section.Section_Number
                            };
                            sep_portion.Sections.Add(ret_section);

                            if (!(headergroup.Controls[0] is KryptonGroupPanel))
                                continue;

                            var kgPnl = headergroup.Controls[0] as KryptonGroupPanel;
                            var ret_items = ReturnSectionItems(kgPnl);
                            if (ret_items != null)
                                ret_section.Items = ret_items;
                        }
                        break;
                    } 
                } 

                return ret_sep_portions;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            }
        }


        private static int ReturnSelectedRow(KryptonGroupPanel kgPnl)
        {
            try
            { 
                for (int pnt_cnt = 0; pnt_cnt < kgPnl.Controls.Count; pnt_cnt++)
                {
                    if (!(kgPnl.Controls[pnt_cnt] is ListView))
                        continue;
                    var lv = (ListView)kgPnl.Controls[pnt_cnt];
                    if (lv.SelectedItems.Count > 0)
                        return lv.SelectedItems[0].Index; 
                }
                return -1;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return -1;
            }
        }

        private static List<Item_ViewModel> ReturnSectionItems(KryptonGroupPanel kgPnl)
        {
            try
            {
                var ret_items = new List<Item_ViewModel>();
                for (int pnt_cnt = 0; pnt_cnt < kgPnl.Controls.Count; pnt_cnt++)
                {
                    if(!(kgPnl.Controls[pnt_cnt] is ListView))
                        continue;
                    var lv = (ListView)kgPnl.Controls[pnt_cnt];
                    var last_item_no = -1;
                    foreach (ListViewItem lvi in lv.Items)
                    {
                        if (!lvi.Checked)
                            continue;
                        var item_no = last_item_no;
                        if (int.TryParse(lvi.SubItems[0].Text, out var lvItemNo))
                            item_no = lvItemNo;

                        ret_items.Add(new Item_ViewModel
                        {
                            ItemNumber = item_no,
                            SubItem =  lvi.SubItems[1].Text,
                            Details =  lvi.SubItems[2].Text,
                            Quantity = lvi.SubItems[3].Text,
                            Unit =     lvi.SubItems[4].Text,
                            Comment =  lvi.SubItems[5].Text
                        });
                    }
                    break;
                }
                return ret_items;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                return null;
            } 
        }
         

        private void CmsListView_InsertRow_Click(object sender, EventArgs e)
        {
            try
            {
                var page = NavSepPortions.SelectedPage;
                for (int ctrl_cnt = 0; ctrl_cnt < page.Controls.Count; ctrl_cnt++)
                {
                    if (!(page.Controls[ctrl_cnt] is Panel))
                        continue;

                    var pnlScroll = page.Controls[ctrl_cnt] as Panel;
                    for (int cnt = 0; cnt < pnlScroll.Controls.Count; cnt++)
                    {
                        if (!(pnlScroll.Controls[cnt] is KryptonHeaderGroup))
                            continue;

                        var headergroup = pnlScroll.Controls[cnt] as KryptonHeaderGroup;
                        Section_Model section = null;

                        if (headergroup.Tag is Section_Model)
                            section = headergroup.Tag as Section_Model; 
                         
                        if (!(headergroup.Controls[0] is KryptonGroupPanel))
                            continue;

                        var kgPnl = headergroup.Controls[0] as KryptonGroupPanel;
                        var ret_items = ReturnSectionItems(kgPnl);
                         
                    }
                    break;
                }
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void PnlLoading_VisibleChanged(object sender, EventArgs e)
        {
            if (PnlLoading.Visible)
                PnlLoading.Location = new System.Drawing.Point((PnlLoading.Size.Width / 2) - 
                                                               (this.Size.Width / 2), 
                                                               PnlLoading.Location.Y);
        }

        private void PnlLoading_StyleChanged(object sender, EventArgs e)
        {
            if (PnlLoading.Visible)
                PnlLoading.Location = new System.Drawing.Point((PnlLoading.Size.Width / 2) -
                                                               (this.Size.Width / 2),
                                                               PnlLoading.Location.Y);
        }

        private void RibGrbBtnFileInfo_Click(object sender, EventArgs e)
        {
            var infoForm = new FrmInfo.FrmInfo();
            infoForm.ShowDialog();
        }

        private void FrmWB_CRUD_SizeChanged(object sender, EventArgs e)
        {
            var extra_width = this.Width;
            var extra_height = NavSepPortions.Height + PnlButtons.Height + RibMain.Height;

            this.RibMain.RibbonAppButton.AppButtonMaxRecentSize =
                new System.Drawing.Size(extra_width, extra_height);
            this.RibMain.RibbonAppButton.AppButtonMinRecentSize =
                new System.Drawing.Size(extra_width, extra_height);
        }

        private void RibMain_AppButtonMenuClosed(object sender, ToolStripDropDownClosedEventArgs e)
        {
            
        }

        private void RibMain_AppButtonMenuOpened(object sender, EventArgs e)
        {  
        }

        private void RibMain_AppButtonMenuClosing(object sender, CancelEventArgs e)
        {
        }

        private void RibMain_AppButtonMenuOpening(object sender, CancelEventArgs e)
        {
        }

        private void RibGrpBtnContractInfo_Click(object sender, EventArgs e)
        {
            QatContractInfo_Click(sender, e);
        } 

        private void LoadQATButtonEvents()
        {
            this.QatContractInfo.Click += QatContractInfo_Click;
            this.QatNewProject.Click += QatNewProject_Click;
            this.QatOpenFile.Click += QatOpenFile_Click;
            this.QatSave.Click += QatSave_Click;
            this.QatSaveAs.Click += QatSaveAs_Click;
            this.QatCreateWorkbook.Click += QatCreateWorkbook_Click;
        }

        private void QatCreateWorkbook_Click(object sender, EventArgs e)
        { 
            try
            {
                var createWbForm = new FrmCreateWorkbook.FrmCreateWorkbook();
                createWbForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex); 
            }
        }

        private void LoadRecentProjects()
        { 
            try
            {
                var recents = new Load_RecentProjects_Controller().Recent_Project_Ribbon_Documents()?.ToArray();
                if (recents == null) return;

                this.RibMain.RibbonAppButton.AppButtonRecentDocs.Clear();
                this.RibMain.RibbonAppButton.AppButtonRecentDocs.AddRange(recents);
                for (int i = 0; i < this.RibMain.RibbonAppButton.AppButtonRecentDocs.Count; i++)
                {
                    this.RibMain.RibbonAppButton.AppButtonRecentDocs[i].Click += FrmWB_CRUD_Click;
                }
                
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void FrmWB_CRUD_Click(object sender, EventArgs e)
        {  // The file path is located in the Tag property
           var project = new Open_Project_Controller().LoadProjectData(
                    ((sender) as KryptonRibbonRecentDoc).Tag as string);
            if (project == null)
            {
                MessageBox.Show("Project Did Not Load.", "Loading Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadProject(project);
            LoadProjectToNavigator();
        }

        private void LoadFileMenuEvents()
        {
            try
            {
                this.MnuFileClose.Click += MnuFileClose_Click;
                this.MnuFileHome.Click += MnuFileHome_Click;
                this.MnuFileInfo.Click += MnuFileInfo_Click;
                this.MnuFileNewProject.Click += QatNewProject_Click;
                this.MnuFileOpenProject.Click += QatOpenFile_Click;
                this.MnuFileSave.Click += QatSave_Click;
                this.MnuFileSaveAs.Click += QatSaveAs_Click; 
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            }
        }

        private void MnuFileInfo_Click(object sender, EventArgs e)
        {
            var info_form = new FrmInfo.FrmInfo();
            info_form.ShowDialog();
        }

        private void MnuFileHome_Click(object sender, EventArgs e)
        {
             
        }

        private void MnuFileClose_Click(object sender, EventArgs e)
        {
            Close();
        } 

        private void QatSaveAs_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                // add file path to project data before passing it 
             
            } 
        }

        private void QatSave_Click(object sender, EventArgs e)
        {
           IWriter writer = new Save_ProjectFile_Helper(_proj_data);
           writer.SaveToFile();
        }

        private void QatOpenFile_Click(object sender, EventArgs e)
        {
            var openForm= new FrmOpenProject.FrmOpenProject();
            openForm.ShowDialog();
        }

        private void QatNewProject_Click(object sender, EventArgs e)
        {
            var new_proj_form = new FrmNewProject.FrmNewProject();
            new_proj_form.ShowDialog();
        }

        private void QatContractInfo_Click(object sender, EventArgs e)
        {
            var contract_form = new FrmContractInfo.FrmContractInfo();
            contract_form.ShowDialog();
        }

        private void FrmWB_CRUD_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void RibGrpBtnCreateWorkbook_Click(object sender, EventArgs e)
        {
            QatCreateWorkbook_Click(sender, e);
        }

        private void BtnSpecEditName_Click(object sender, EventArgs e)
        {
            var btn = sender as ButtonSpecAny;
            var str = string.Empty;
        }

        private void KCMPage_Opening(object sender, CancelEventArgs e)
        {

        }

        private void KCMPage_Closing(object sender, CancelEventArgs e)
        {
            try
            {
                var mnu = sender as KryptonContextMenu;
                var input =  new FrmInput.FrmInput("Edit Name", "Edit Separable Portion Name", 
                                       ((KryptonPage)((ButtonSpecAny)mnu.Caller).Owner).Text);
                if (input.ShowDialog() == DialogResult.OK) 
                {
                    var name = ((ButtonSpecAny)mnu.Caller).Owner.ToString();

                   ((KryptonPage) ((ButtonSpecAny)mnu.Caller).Owner).Text = input.RetrieveUserResponse();
                }
                var str = string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionHelper.HandleException(ex);
                throw;
            } 
        }
    }
}
