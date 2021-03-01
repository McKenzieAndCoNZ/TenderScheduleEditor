
namespace PaymentsScheduleTemplateCreator.Forms.FrmWB_CRUD
{
    partial class FrmWB_CRUD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWB_CRUD));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.LblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.KCMPage = new ComponentFactory.Krypton.Toolkit.KryptonContextMenu();
            this.kryptonContextMenuItems1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems();
            this.kryptonContextMenuItem2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.cmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsListView_InsertRow = new System.Windows.Forms.ToolStripMenuItem();
            this.RibMain = new ComponentFactory.Krypton.Ribbon.KryptonRibbon();
            this.QatOpenFile = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.QatNewProject = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.QatSave = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.QatSaveAs = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.QatContractInfo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.QatCreateWorkbook = new ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton();
            this.MnuFileHome = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.MnuFileNewProject = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.MnuFileOpenProject = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator1 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.MnuFileInfo = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.MnuFileSave = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.MnuFileSaveAs = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.kryptonContextMenuSeparator2 = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator();
            this.MnuFileClose = new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem();
            this.RibTabView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab();
            this.RibGrpView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.RibGrpTripView = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.RibGrpBtnContractInfo = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.RibGrpCreateWorkbooks = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup();
            this.kryptonRibbonGroupTriple2 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.RibGrpBtnCreateTenderSchedule = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.kryptonRibbonGroupSeparator1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator();
            this.kryptonRibbonGroupTriple3 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple();
            this.RibGptBtnCreateEngineerEstimate = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.RibRecentDoc1 = new ComponentFactory.Krypton.Ribbon.KryptonRibbonRecentDoc();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.NavSepPortions = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.BtnSpecAddPage = new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator();
            this.PageSP1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.BtnSpecEditName = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.PnlScroll = new System.Windows.Forms.Panel();
            this.PnlLoading = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.loadingCircle1 = new MRG.Controls.UI.LoadingCircle();
            this.RbGrpEngEstTeste = new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton();
            this.statusStrip1.SuspendLayout();
            this.cmsListView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RibMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavSepPortions)).BeginInit();
            this.NavSepPortions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSP1)).BeginInit();
            this.PageSP1.SuspendLayout();
            this.PnlScroll.SuspendLayout();
            this.PnlLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1,
            this.LblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(830, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // LblStatus
            // 
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // KCMPage
            // 
            this.KCMPage.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItems1});
            this.KCMPage.Opening += new System.ComponentModel.CancelEventHandler(this.KCMPage_Opening);
            this.KCMPage.Closing += new System.ComponentModel.CancelEventHandler(this.KCMPage_Closing);
            // 
            // kryptonContextMenuItems1
            // 
            this.kryptonContextMenuItems1.Items.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.kryptonContextMenuItem2});
            // 
            // kryptonContextMenuItem2
            // 
            this.kryptonContextMenuItem2.Text = "Edit Name";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // cmsListView
            // 
            this.cmsListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.cmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsListView_InsertRow});
            this.cmsListView.Name = "cmsListView";
            this.cmsListView.Size = new System.Drawing.Size(132, 26);
            // 
            // CmsListView_InsertRow
            // 
            this.CmsListView_InsertRow.Name = "CmsListView_InsertRow";
            this.CmsListView_InsertRow.Size = new System.Drawing.Size(131, 22);
            this.CmsListView_InsertRow.Text = "Insert Row";
            this.CmsListView_InsertRow.Click += new System.EventHandler(this.CmsListView_InsertRow_Click);
            // 
            // RibMain
            // 
            this.RibMain.AllowFormIntegrate = true;
            this.RibMain.InDesignHelperMode = true;
            this.RibMain.MinimizedMode = true;
            this.RibMain.Name = "RibMain";
            this.RibMain.QATButtons.AddRange(new System.ComponentModel.Component[] {
            this.QatOpenFile,
            this.QatNewProject,
            this.QatSave,
            this.QatSaveAs,
            this.QatContractInfo,
            this.QatCreateWorkbook});
            this.RibMain.RibbonAppButton.AppButtonMenuItems.AddRange(new ComponentFactory.Krypton.Toolkit.KryptonContextMenuItemBase[] {
            this.MnuFileHome,
            this.MnuFileNewProject,
            this.MnuFileOpenProject,
            this.kryptonContextMenuSeparator1,
            this.MnuFileInfo,
            this.MnuFileSave,
            this.MnuFileSaveAs,
            this.kryptonContextMenuSeparator2,
            this.MnuFileClose});
            this.RibMain.RibbonTabs.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonTab[] {
            this.RibTabView});
            this.RibMain.SelectedTab = this.RibTabView;
            this.RibMain.Size = new System.Drawing.Size(830, 127);
            this.RibMain.StateCommon.RibbonGeneral.TextFont = new System.Drawing.Font("Axiforma Book", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RibMain.StateCommon.RibbonGeneral.TextHint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.RibMain.TabIndex = 1;
            this.RibMain.AppButtonMenuOpening += new System.ComponentModel.CancelEventHandler(this.RibMain_AppButtonMenuOpening);
            this.RibMain.AppButtonMenuOpened += new System.EventHandler(this.RibMain_AppButtonMenuOpened);
            this.RibMain.AppButtonMenuClosing += new System.ComponentModel.CancelEventHandler(this.RibMain_AppButtonMenuClosing);
            this.RibMain.AppButtonMenuClosed += new System.Windows.Forms.ToolStripDropDownClosedEventHandler(this.RibMain_AppButtonMenuClosed);
            // 
            // QatOpenFile
            // 
            this.QatOpenFile.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Open_Blue_16;
            this.QatOpenFile.Text = "Open";
            this.QatOpenFile.ToolTipBody = "Open a Project";
            this.QatOpenFile.ToolTipTitle = "Open";
            // 
            // QatNewProject
            // 
            this.QatNewProject.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.New_Blue_16;
            this.QatNewProject.Text = "New Project";
            this.QatNewProject.ToolTipBody = "Create a New Project";
            this.QatNewProject.ToolTipTitle = "New Project";
            // 
            // QatSave
            // 
            this.QatSave.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Save_Blue_16;
            this.QatSave.Text = "Save";
            this.QatSave.ToolTipBody = "Save the Project";
            this.QatSave.ToolTipTitle = "Save";
            // 
            // QatSaveAs
            // 
            this.QatSaveAs.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Save_as_Blue_16;
            this.QatSaveAs.Text = "Save As";
            this.QatSaveAs.ToolTipBody = "Change the Name of the Project";
            this.QatSaveAs.ToolTipTitle = "Save As";
            // 
            // QatContractInfo
            // 
            this.QatContractInfo.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.contract_info_16;
            this.QatContractInfo.Text = "Contract Info";
            this.QatContractInfo.ToolTipBody = "Edit the Contract Information";
            this.QatContractInfo.ToolTipTitle = "Contract Information";
            // 
            // QatCreateWorkbook
            // 
            this.QatCreateWorkbook.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.excel_16;
            this.QatCreateWorkbook.Text = "Create Workbook";
            this.QatCreateWorkbook.ToolTipBody = "Output the Data in the Project Into a Workbook. ";
            this.QatCreateWorkbook.ToolTipTitle = "Create Workbook";
            // 
            // MnuFileHome
            // 
            this.MnuFileHome.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.home_16;
            this.MnuFileHome.Text = "Home";
            // 
            // MnuFileNewProject
            // 
            this.MnuFileNewProject.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.New_Blue_16;
            this.MnuFileNewProject.Text = "New Project";
            // 
            // MnuFileOpenProject
            // 
            this.MnuFileOpenProject.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Open_Blue_16;
            this.MnuFileOpenProject.Text = "Open Project";
            // 
            // MnuFileInfo
            // 
            this.MnuFileInfo.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Info_16;
            this.MnuFileInfo.Text = "Info";
            // 
            // MnuFileSave
            // 
            this.MnuFileSave.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Save_Blue_16;
            this.MnuFileSave.Text = "Save";
            // 
            // MnuFileSaveAs
            // 
            this.MnuFileSaveAs.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Save_as_Blue_16;
            this.MnuFileSaveAs.Text = "Save As";
            // 
            // MnuFileClose
            // 
            this.MnuFileClose.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Close_Red_16;
            this.MnuFileClose.Text = "Close";
            // 
            // RibTabView
            // 
            this.RibTabView.Groups.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup[] {
            this.RibGrpView,
            this.RibGrpCreateWorkbooks});
            this.RibTabView.Text = "Home";
            // 
            // RibGrpView
            // 
            this.RibGrpView.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.RibGrpTripView});
            this.RibGrpView.TextLine1 = "Options";
            // 
            // RibGrpTripView
            // 
            this.RibGrpTripView.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.RibGrpBtnContractInfo});
            // 
            // RibGrpBtnContractInfo
            // 
            this.RibGrpBtnContractInfo.ImageLarge = global::PaymentsScheduleTemplateCreator.Properties.Resources.contract_info_32;
            this.RibGrpBtnContractInfo.ImageSmall = global::PaymentsScheduleTemplateCreator.Properties.Resources.contract_info_16;
            this.RibGrpBtnContractInfo.TextLine1 = "Contract";
            this.RibGrpBtnContractInfo.TextLine2 = "Info";
            this.RibGrpBtnContractInfo.ToolTipBody = "Edit the Contract Information.";
            this.RibGrpBtnContractInfo.ToolTipTitle = "Contract Information";
            this.RibGrpBtnContractInfo.Click += new System.EventHandler(this.RibGrpBtnContractInfo_Click);
            // 
            // RibGrpCreateWorkbooks
            // 
            this.RibGrpCreateWorkbooks.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupContainer[] {
            this.kryptonRibbonGroupTriple2,
            this.kryptonRibbonGroupSeparator1,
            this.kryptonRibbonGroupTriple3});
            this.RibGrpCreateWorkbooks.TextLine1 = "Create Workbooks";
            // 
            // kryptonRibbonGroupTriple2
            // 
            this.kryptonRibbonGroupTriple2.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.RibGrpBtnCreateTenderSchedule});
            // 
            // RibGrpBtnCreateTenderSchedule
            // 
            this.RibGrpBtnCreateTenderSchedule.ImageLarge = global::PaymentsScheduleTemplateCreator.Properties.Resources.Excel_32;
            this.RibGrpBtnCreateTenderSchedule.ImageSmall = global::PaymentsScheduleTemplateCreator.Properties.Resources.excel_16;
            this.RibGrpBtnCreateTenderSchedule.TextLine1 = "Tender";
            this.RibGrpBtnCreateTenderSchedule.TextLine2 = "Schedule";
            this.RibGrpBtnCreateTenderSchedule.ToolTipBody = "Output the Project Into the Workbook that will be used the manage the Payment Sch" +
    "edule with the contractor.";
            this.RibGrpBtnCreateTenderSchedule.ToolTipTitle = "Create Payment Schedule Workbook";
            this.RibGrpBtnCreateTenderSchedule.Click += new System.EventHandler(this.RibGrpBtnCreateWorkbook_Click);
            // 
            // kryptonRibbonGroupTriple3
            // 
            this.kryptonRibbonGroupTriple3.Items.AddRange(new ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupItem[] {
            this.RibGptBtnCreateEngineerEstimate});
            // 
            // RibGptBtnCreateEngineerEstimate
            // 
            this.RibGptBtnCreateEngineerEstimate.ImageLarge = global::PaymentsScheduleTemplateCreator.Properties.Resources.Excel_32;
            this.RibGptBtnCreateEngineerEstimate.ImageSmall = global::PaymentsScheduleTemplateCreator.Properties.Resources.excel_16;
            this.RibGptBtnCreateEngineerEstimate.TextLine1 = "Engineer";
            this.RibGptBtnCreateEngineerEstimate.TextLine2 = "Estimate";
            // 
            // RibRecentDoc1
            // 
            this.RibRecentDoc1.ExtraText = "Extra Text";
            this.RibRecentDoc1.Text = "Recent Document 1";
            // 
            // PnlButtons
            // 
            this.PnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlButtons.Location = new System.Drawing.Point(0, 551);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(830, 37);
            this.PnlButtons.TabIndex = 69;
            // 
            // NavSepPortions
            // 
            this.NavSepPortions.Button.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator[] {
            this.BtnSpecAddPage});
            // 
            // 
            // 
            this.NavSepPortions.Button.CloseButton.Text = "Delete Selected";
            this.NavSepPortions.Button.CloseButton.ToolTipBody = "Remove Separable Portion";
            this.NavSepPortions.Button.CloseButton.ToolTipTitle = "Delete Selected Separable Portion";
            this.NavSepPortions.Button.CloseButton.UniqueName = "78d0d979c518405c86487fdd6406a493";
            // 
            // 
            // 
            this.NavSepPortions.Button.ContextButton.Text = "Select";
            this.NavSepPortions.Button.ContextButton.UniqueName = "bb7ea3f8ff304bcf866f04e0439603d8";
            // 
            // 
            // 
            this.NavSepPortions.Button.NextButton.ToolTipBody = "Next Button";
            this.NavSepPortions.Button.NextButton.UniqueName = "92354ef62af144819b87fe7dfccf2d09";
            // 
            // 
            // 
            this.NavSepPortions.Button.PreviousButton.ToolTipBody = "Previous Button";
            this.NavSepPortions.Button.PreviousButton.UniqueName = "e6ab64771cb3428c9c5eec91a4eab5a8";
            this.NavSepPortions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavSepPortions.Location = new System.Drawing.Point(0, 127);
            this.NavSepPortions.Name = "NavSepPortions";
            this.NavSepPortions.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.PageSP1});
            this.NavSepPortions.SelectedIndex = 0;
            this.NavSepPortions.Size = new System.Drawing.Size(830, 424);
            this.NavSepPortions.TabIndex = 70;
            this.NavSepPortions.Text = "kryptonNavigator1";
            // 
            // BtnSpecAddPage
            // 
            this.BtnSpecAddPage.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.add_16;
            this.BtnSpecAddPage.Text = "Add Separable Portion";
            this.BtnSpecAddPage.ToolTipBody = "Add a new Separable Portion";
            this.BtnSpecAddPage.ToolTipTitle = "Add New";
            this.BtnSpecAddPage.UniqueName = "ae47b04fbec74fb0bc36e42956e91434";
            this.BtnSpecAddPage.Click += new System.EventHandler(this.BtnSpecAddPage_Click);
            // 
            // PageSP1
            // 
            this.PageSP1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.PageSP1.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BtnSpecEditName});
            this.PageSP1.Controls.Add(this.PnlScroll);
            this.PageSP1.Flags = 65534;
            this.PageSP1.LastVisibleSet = true;
            this.PageSP1.MinimumSize = new System.Drawing.Size(50, 50);
            this.PageSP1.Name = "PageSP1";
            this.PageSP1.Size = new System.Drawing.Size(828, 392);
            this.PageSP1.Text = "Separable Portion 1";
            this.PageSP1.ToolTipTitle = "Page ToolTip";
            this.PageSP1.UniqueName = "8f8f8c6d09f04380b5a1ac79f4d16fbf";
            // 
            // BtnSpecEditName
            // 
            this.BtnSpecEditName.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.edit_16;
            this.BtnSpecEditName.ImageTransparentColor = System.Drawing.SystemColors.Control;
            this.BtnSpecEditName.KryptonContextMenu = this.KCMPage;
            this.BtnSpecEditName.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom2;
            this.BtnSpecEditName.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.FormMin;
            this.BtnSpecEditName.UniqueName = "e1f28e8c794e451085e86d8ebd5e8b03";
            this.BtnSpecEditName.Click += new System.EventHandler(this.BtnSpecEditName_Click);
            // 
            // PnlScroll
            // 
            this.PnlScroll.Controls.Add(this.PnlLoading);
            this.PnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlScroll.Location = new System.Drawing.Point(0, 0);
            this.PnlScroll.Name = "PnlScroll";
            this.PnlScroll.Size = new System.Drawing.Size(828, 392);
            this.PnlScroll.TabIndex = 0;
            // 
            // PnlLoading
            // 
            this.PnlLoading.Controls.Add(this.kryptonLabel1);
            this.PnlLoading.Controls.Add(this.loadingCircle1);
            this.PnlLoading.Location = new System.Drawing.Point(253, 87);
            this.PnlLoading.Name = "PnlLoading";
            this.PnlLoading.Size = new System.Drawing.Size(311, 218);
            this.PnlLoading.TabIndex = 22;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(304, 38);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.ExtraText = "Please Wait ...";
            this.kryptonLabel1.Values.Text = "Loading ";
            // 
            // loadingCircle1
            // 
            this.loadingCircle1.Active = false;
            this.loadingCircle1.BackColor = System.Drawing.Color.Transparent;
            this.loadingCircle1.Color = System.Drawing.Color.Black;
            this.loadingCircle1.InnerCircleRadius = 5;
            this.loadingCircle1.Location = new System.Drawing.Point(43, 47);
            this.loadingCircle1.Name = "loadingCircle1";
            this.loadingCircle1.NumberSpoke = 12;
            this.loadingCircle1.OuterCircleRadius = 11;
            this.loadingCircle1.RotationSpeed = 100;
            this.loadingCircle1.Size = new System.Drawing.Size(228, 160);
            this.loadingCircle1.SpokeThickness = 2;
            this.loadingCircle1.StylePreset = MRG.Controls.UI.LoadingCircle.StylePresets.MacOSX;
            this.loadingCircle1.TabIndex = 0;
            this.loadingCircle1.Text = "loadingCircle1";
            // 
            // FrmWB_CRUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 610);
            this.Controls.Add(this.NavSepPortions);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.RibMain);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmWB_CRUD";
            this.Text = "Payments Workbook Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmWB_CRUD_FormClosed);
            this.Load += new System.EventHandler(this.FrmWB_CRUD_Load);
            this.Shown += new System.EventHandler(this.FrmWB_CRUD_Shown);
            this.SizeChanged += new System.EventHandler(this.FrmWB_CRUD_SizeChanged);
            this.Resize += new System.EventHandler(this.FrmWB_CRUD_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.cmsListView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RibMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NavSepPortions)).EndInit();
            this.NavSepPortions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PageSP1)).EndInit();
            this.PageSP1.ResumeLayout(false);
            this.PnlScroll.ResumeLayout(false);
            this.PnlLoading.ResumeLayout(false);
            this.PnlLoading.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenu KCMPage;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItems kryptonContextMenuItems1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem kryptonContextMenuItem2;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.ContextMenuStrip cmsListView;
        private System.Windows.Forms.ToolStripMenuItem CmsListView_InsertRow;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbon RibMain;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonTab RibTabView;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup RibGrpView;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple RibGrpTripView;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton RibGrpBtnContractInfo;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatOpenFile;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatNewProject;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatSave;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatSaveAs;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatContractInfo;
        private System.Windows.Forms.Panel PnlButtons;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavSepPortions;
        private ComponentFactory.Krypton.Navigator.ButtonSpecNavigator BtnSpecAddPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage PageSP1;
        private System.Windows.Forms.Panel PnlScroll;
        private System.Windows.Forms.Panel PnlLoading;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private MRG.Controls.UI.LoadingCircle loadingCircle1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileNewProject;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileOpenProject;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator1;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileHome;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileSave;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileInfo;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileSaveAs;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuSeparator kryptonContextMenuSeparator2;
        private ComponentFactory.Krypton.Toolkit.KryptonContextMenuItem MnuFileClose;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonRecentDoc RibRecentDoc1;
        private System.Windows.Forms.ToolStripStatusLabel LblStatus;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton RibGrpBtnCreateTenderSchedule;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BtnSpecEditName;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonQATButton QatCreateWorkbook;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroup RibGrpCreateWorkbooks;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple2;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton RibGptBtnCreateEngineerEstimate;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupSeparator kryptonRibbonGroupSeparator1;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupTriple kryptonRibbonGroupTriple3;
        private ComponentFactory.Krypton.Ribbon.KryptonRibbonGroupButton RbGrpEngEstTeste;
    }
}