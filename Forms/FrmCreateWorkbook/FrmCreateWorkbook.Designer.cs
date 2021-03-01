
namespace PaymentsScheduleTemplateCreator.Forms.FrmCreateWorkbook
{
    partial class FrmCreateWorkbook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCreateWorkbook));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCreateWorkbook = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.GrpBxInitialMonth = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.TxtCurrentMonth = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.DTPCustomMonth = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.RdoUseCustomMonth = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.RdoUseCurrentMonth = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.GrpBxWorkbookLocation = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.TxtWorkbookLocation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.BtnSpecNavToWorkbook = new ComponentFactory.Krypton.Toolkit.ButtonSpecAny();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.GrpApproval = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.TxtApprovedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtReviewedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.TxtCreatedBy = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxInitialMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxInitialMonth.Panel)).BeginInit();
            this.GrpBxInitialMonth.Panel.SuspendLayout();
            this.GrpBxInitialMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxWorkbookLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxWorkbookLocation.Panel)).BeginInit();
            this.GrpBxWorkbookLocation.Panel.SuspendLayout();
            this.GrpBxWorkbookLocation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpApproval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpApproval.Panel)).BeginInit();
            this.GrpApproval.Panel.SuspendLayout();
            this.GrpApproval.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnCancel);
            this.panel1.Controls.Add(this.BtnCreateWorkbook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(672, 46);
            this.panel1.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(442, 9);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 25);
            this.BtnCancel.TabIndex = 32;
            this.BtnCancel.Values.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnCreateWorkbook
            // 
            this.BtnCreateWorkbook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateWorkbook.Location = new System.Drawing.Point(548, 9);
            this.BtnCreateWorkbook.Name = "BtnCreateWorkbook";
            this.BtnCreateWorkbook.Size = new System.Drawing.Size(112, 25);
            this.BtnCreateWorkbook.TabIndex = 31;
            this.BtnCreateWorkbook.Values.Text = "Create Workbook";
            this.BtnCreateWorkbook.Click += new System.EventHandler(this.BtnCreateWorkbook_Click);
            // 
            // GrpBxInitialMonth
            // 
            this.GrpBxInitialMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxInitialMonth.Location = new System.Drawing.Point(5, 13);
            this.GrpBxInitialMonth.Name = "GrpBxInitialMonth";
            // 
            // GrpBxInitialMonth.Panel
            // 
            this.GrpBxInitialMonth.Panel.Controls.Add(this.TxtCurrentMonth);
            this.GrpBxInitialMonth.Panel.Controls.Add(this.DTPCustomMonth);
            this.GrpBxInitialMonth.Panel.Controls.Add(this.RdoUseCustomMonth);
            this.GrpBxInitialMonth.Panel.Controls.Add(this.RdoUseCurrentMonth);
            this.GrpBxInitialMonth.Size = new System.Drawing.Size(667, 119);
            this.GrpBxInitialMonth.TabIndex = 1;
            this.GrpBxInitialMonth.Values.Heading = "Initial Month Used As Name of Monthly Claim";
            // 
            // TxtCurrentMonth
            // 
            this.TxtCurrentMonth.Location = new System.Drawing.Point(148, 12);
            this.TxtCurrentMonth.Name = "TxtCurrentMonth";
            this.TxtCurrentMonth.ReadOnly = true;
            this.TxtCurrentMonth.Size = new System.Drawing.Size(55, 20);
            this.TxtCurrentMonth.TabIndex = 3;
            this.TxtCurrentMonth.Text = "Feb 21";
            // 
            // DTPCustomMonth
            // 
            this.DTPCustomMonth.CustomFormat = "MMM yy";
            this.DTPCustomMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DTPCustomMonth.Location = new System.Drawing.Point(74, 70);
            this.DTPCustomMonth.Name = "DTPCustomMonth";
            this.DTPCustomMonth.Size = new System.Drawing.Size(68, 18);
            this.DTPCustomMonth.TabIndex = 2;
            // 
            // RdoUseCustomMonth
            // 
            this.RdoUseCustomMonth.Location = new System.Drawing.Point(23, 46);
            this.RdoUseCustomMonth.Name = "RdoUseCustomMonth";
            this.RdoUseCustomMonth.Size = new System.Drawing.Size(120, 18);
            this.RdoUseCustomMonth.TabIndex = 1;
            this.RdoUseCustomMonth.Values.Text = "Use Custom Month";
            this.RdoUseCustomMonth.CheckedChanged += new System.EventHandler(this.RdoUseCustomMonth_CheckedChanged);
            // 
            // RdoUseCurrentMonth
            // 
            this.RdoUseCurrentMonth.Checked = true;
            this.RdoUseCurrentMonth.Location = new System.Drawing.Point(23, 12);
            this.RdoUseCurrentMonth.Name = "RdoUseCurrentMonth";
            this.RdoUseCurrentMonth.Size = new System.Drawing.Size(119, 18);
            this.RdoUseCurrentMonth.TabIndex = 0;
            this.RdoUseCurrentMonth.Values.Text = "Use Current Month";
            this.RdoUseCurrentMonth.CheckedChanged += new System.EventHandler(this.RdoUseCurrentMonth_CheckedChanged);
            // 
            // GrpBxWorkbookLocation
            // 
            this.GrpBxWorkbookLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpBxWorkbookLocation.Location = new System.Drawing.Point(5, 147);
            this.GrpBxWorkbookLocation.Name = "GrpBxWorkbookLocation";
            // 
            // GrpBxWorkbookLocation.Panel
            // 
            this.GrpBxWorkbookLocation.Panel.Controls.Add(this.TxtWorkbookLocation);
            this.GrpBxWorkbookLocation.Size = new System.Drawing.Size(667, 84);
            this.GrpBxWorkbookLocation.TabIndex = 2;
            this.GrpBxWorkbookLocation.ToolTipValues.Heading = "Workbook Location";
            this.GrpBxWorkbookLocation.Values.Heading = "Workbook Location";
            // 
            // TxtWorkbookLocation
            // 
            this.TxtWorkbookLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtWorkbookLocation.ButtonSpecs.AddRange(new ComponentFactory.Krypton.Toolkit.ButtonSpecAny[] {
            this.BtnSpecNavToWorkbook});
            this.TxtWorkbookLocation.Location = new System.Drawing.Point(3, 15);
            this.TxtWorkbookLocation.Name = "TxtWorkbookLocation";
            this.TxtWorkbookLocation.Size = new System.Drawing.Size(654, 26);
            this.TxtWorkbookLocation.TabIndex = 0;
            // 
            // BtnSpecNavToWorkbook
            // 
            this.BtnSpecNavToWorkbook.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.ellipsis_16;
            this.BtnSpecNavToWorkbook.Style = ComponentFactory.Krypton.Toolkit.PaletteButtonStyle.Custom1;
            this.BtnSpecNavToWorkbook.ToolTipBody = "Browse to Workbook Location";
            this.BtnSpecNavToWorkbook.ToolTipTitle = "Browse";
            this.BtnSpecNavToWorkbook.Type = ComponentFactory.Krypton.Toolkit.PaletteButtonSpecStyle.Context;
            this.BtnSpecNavToWorkbook.UniqueName = "40f8d6adbc9b4147947ce678789a2e73";
            this.BtnSpecNavToWorkbook.Click += new System.EventHandler(this.BtnSpecNavToWorkbook_Click);
            // 
            // GrpApproval
            // 
            this.GrpApproval.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpApproval.Location = new System.Drawing.Point(5, 247);
            this.GrpApproval.Name = "GrpApproval";
            // 
            // GrpApproval.Panel
            // 
            this.GrpApproval.Panel.Controls.Add(this.TxtApprovedBy);
            this.GrpApproval.Panel.Controls.Add(this.TxtReviewedBy);
            this.GrpApproval.Panel.Controls.Add(this.TxtCreatedBy);
            this.GrpApproval.Panel.Controls.Add(this.kryptonLabel3);
            this.GrpApproval.Panel.Controls.Add(this.kryptonLabel2);
            this.GrpApproval.Panel.Controls.Add(this.kryptonLabel1);
            this.GrpApproval.Size = new System.Drawing.Size(667, 174);
            this.GrpApproval.TabIndex = 3;
            this.GrpApproval.Values.Heading = "Tender Schedule Approval";
            // 
            // TxtApprovedBy
            // 
            this.TxtApprovedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApprovedBy.Location = new System.Drawing.Point(71, 112);
            this.TxtApprovedBy.Name = "TxtApprovedBy";
            this.TxtApprovedBy.Size = new System.Drawing.Size(583, 20);
            this.TxtApprovedBy.TabIndex = 14;
            // 
            // TxtReviewedBy
            // 
            this.TxtReviewedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReviewedBy.Location = new System.Drawing.Point(72, 65);
            this.TxtReviewedBy.Name = "TxtReviewedBy";
            this.TxtReviewedBy.Size = new System.Drawing.Size(583, 20);
            this.TxtReviewedBy.TabIndex = 13;
            // 
            // TxtCreatedBy
            // 
            this.TxtCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCreatedBy.Location = new System.Drawing.Point(72, 18);
            this.TxtCreatedBy.Name = "TxtCreatedBy";
            this.TxtCreatedBy.Size = new System.Drawing.Size(583, 20);
            this.TxtCreatedBy.TabIndex = 12;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(2, 114);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(75, 18);
            this.kryptonLabel3.TabIndex = 11;
            this.kryptonLabel3.Values.Text = "Approved By";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(1, 67);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(76, 18);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Reviewed By";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 20);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(67, 18);
            this.kryptonLabel1.TabIndex = 9;
            this.kryptonLabel1.Values.Text = "Created By";
            // 
            // FrmCreateWorkbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 473);
            this.Controls.Add(this.GrpApproval);
            this.Controls.Add(this.GrpBxWorkbookLocation);
            this.Controls.Add(this.GrpBxInitialMonth);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCreateWorkbook";
            this.Text = "Create Workbook";
            this.Load += new System.EventHandler(this.FrmCreateWorkbook_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxInitialMonth.Panel)).EndInit();
            this.GrpBxInitialMonth.Panel.ResumeLayout(false);
            this.GrpBxInitialMonth.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxInitialMonth)).EndInit();
            this.GrpBxInitialMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxWorkbookLocation.Panel)).EndInit();
            this.GrpBxWorkbookLocation.Panel.ResumeLayout(false);
            this.GrpBxWorkbookLocation.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpBxWorkbookLocation)).EndInit();
            this.GrpBxWorkbookLocation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpApproval.Panel)).EndInit();
            this.GrpApproval.Panel.ResumeLayout(false);
            this.GrpApproval.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpApproval)).EndInit();
            this.GrpApproval.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Panel panel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCreateWorkbook;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GrpBxInitialMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtCurrentMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DTPCustomMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RdoUseCustomMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton RdoUseCurrentMonth;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GrpBxWorkbookLocation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtWorkbookLocation;
        private ComponentFactory.Krypton.Toolkit.ButtonSpecAny BtnSpecNavToWorkbook;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GrpApproval;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtApprovedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtReviewedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtCreatedBy;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}