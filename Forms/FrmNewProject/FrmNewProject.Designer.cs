
namespace PaymentsScheduleTemplateCreator.Forms.FrmNewProject
{
    partial class FrmNewProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewProject));
            this.PnlBottom = new System.Windows.Forms.Panel();
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnOk = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.GrpbxProject = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.BtnNavToProgressPaymentsWB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtProgressPaymentsWorkbookPath = new System.Windows.Forms.TextBox();
            this.TxtProjectName = new System.Windows.Forms.TextBox();
            this.GrpbxAttributes = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.NUDNoOfLots = new ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.TxtComments = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.PnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxProject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxProject.Panel)).BeginInit();
            this.GrpbxProject.Panel.SuspendLayout();
            this.GrpbxProject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxAttributes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxAttributes.Panel)).BeginInit();
            this.GrpbxAttributes.Panel.SuspendLayout();
            this.GrpbxAttributes.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBottom
            // 
            this.PnlBottom.Controls.Add(this.BtnCancel);
            this.PnlBottom.Controls.Add(this.BtnOk);
            this.PnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlBottom.Location = new System.Drawing.Point(0, 348);
            this.PnlBottom.Name = "PnlBottom";
            this.PnlBottom.Size = new System.Drawing.Size(407, 48);
            this.PnlBottom.TabIndex = 0;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(180, 11);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 25);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Values.Text = "Cancel";
            // 
            // BtnOk
            // 
            this.BtnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOk.Location = new System.Drawing.Point(308, 11);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(90, 25);
            this.BtnOk.TabIndex = 2;
            this.BtnOk.Values.Text = "Save && Exit";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // GrpbxProject
            // 
            this.GrpbxProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpbxProject.Location = new System.Drawing.Point(0, 14);
            this.GrpbxProject.Name = "GrpbxProject";
            // 
            // GrpbxProject.Panel
            // 
            this.GrpbxProject.Panel.Controls.Add(this.kryptonLabel2);
            this.GrpbxProject.Panel.Controls.Add(this.kryptonLabel1);
            this.GrpbxProject.Panel.Controls.Add(this.BtnNavToProgressPaymentsWB);
            this.GrpbxProject.Panel.Controls.Add(this.TxtProgressPaymentsWorkbookPath);
            this.GrpbxProject.Panel.Controls.Add(this.TxtProjectName);
            this.GrpbxProject.Size = new System.Drawing.Size(407, 129);
            this.GrpbxProject.TabIndex = 1;
            this.GrpbxProject.Values.Heading = "Project";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(4, 55);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(144, 18);
            this.kryptonLabel2.TabIndex = 83;
            this.kryptonLabel2.Values.Text = "Workbook Output Location";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(3, 3);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(138, 22);
            this.kryptonLabel1.TabIndex = 82;
            this.kryptonLabel1.Values.ExtraText = "(required)";
            this.kryptonLabel1.Values.Text = "Project Name";
            // 
            // BtnNavToProgressPaymentsWB
            // 
            this.BtnNavToProgressPaymentsWB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNavToProgressPaymentsWB.Location = new System.Drawing.Point(368, 79);
            this.BtnNavToProgressPaymentsWB.Name = "BtnNavToProgressPaymentsWB";
            this.BtnNavToProgressPaymentsWB.Size = new System.Drawing.Size(28, 20);
            this.BtnNavToProgressPaymentsWB.TabIndex = 81;
            this.BtnNavToProgressPaymentsWB.ToolTipValues.Description = "The Progress Payments Workbook will typically be an empty Template workbook. You " +
    "may use an existing workbook if you plan to add Separable Portions to it.";
            this.BtnNavToProgressPaymentsWB.ToolTipValues.EnableToolTips = true;
            this.BtnNavToProgressPaymentsWB.ToolTipValues.Heading = "Progress Payments Workbook ";
            this.BtnNavToProgressPaymentsWB.ToolTipValues.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.search_16;
            this.BtnNavToProgressPaymentsWB.Values.Text = "...";
            // 
            // TxtProgressPaymentsWorkbookPath
            // 
            this.TxtProgressPaymentsWorkbookPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProgressPaymentsWorkbookPath.Location = new System.Drawing.Point(4, 79);
            this.TxtProgressPaymentsWorkbookPath.Name = "TxtProgressPaymentsWorkbookPath";
            this.TxtProgressPaymentsWorkbookPath.Size = new System.Drawing.Size(358, 20);
            this.TxtProgressPaymentsWorkbookPath.TabIndex = 80;
            this.TxtProgressPaymentsWorkbookPath.Text = "<Location to Create the Workbook>";
            // 
            // TxtProjectName
            // 
            this.TxtProjectName.AcceptsReturn = true;
            this.TxtProjectName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtProjectName.Location = new System.Drawing.Point(4, 27);
            this.TxtProjectName.Name = "TxtProjectName";
            this.TxtProjectName.Size = new System.Drawing.Size(392, 20);
            this.TxtProjectName.TabIndex = 79;
            // 
            // GrpbxAttributes
            // 
            this.GrpbxAttributes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpbxAttributes.Location = new System.Drawing.Point(4, 154);
            this.GrpbxAttributes.Name = "GrpbxAttributes";
            // 
            // GrpbxAttributes.Panel
            // 
            this.GrpbxAttributes.Panel.Controls.Add(this.TxtComments);
            this.GrpbxAttributes.Panel.Controls.Add(this.kryptonLabel4);
            this.GrpbxAttributes.Panel.Controls.Add(this.NUDNoOfLots);
            this.GrpbxAttributes.Panel.Controls.Add(this.kryptonLabel3);
            this.GrpbxAttributes.Size = new System.Drawing.Size(402, 158);
            this.GrpbxAttributes.TabIndex = 2;
            this.GrpbxAttributes.Values.Heading = "Attributes";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(6, 3);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(62, 18);
            this.kryptonLabel3.TabIndex = 0;
            this.kryptonLabel3.Values.Text = "No of Lots";
            // 
            // NUDNoOfLots
            // 
            this.NUDNoOfLots.Location = new System.Drawing.Point(90, 3);
            this.NUDNoOfLots.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUDNoOfLots.Name = "NUDNoOfLots";
            this.NUDNoOfLots.Size = new System.Drawing.Size(57, 19);
            this.NUDNoOfLots.TabIndex = 1;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(3, 36);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(65, 18);
            this.kryptonLabel4.TabIndex = 2;
            this.kryptonLabel4.Values.Text = "Comments";
            // 
            // TxtComments
            // 
            this.TxtComments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComments.Location = new System.Drawing.Point(6, 51);
            this.TxtComments.Multiline = true;
            this.TxtComments.Name = "TxtComments";
            this.TxtComments.Size = new System.Drawing.Size(389, 84);
            this.TxtComments.TabIndex = 3;
            // 
            // FrmNewProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 396);
            this.Controls.Add(this.GrpbxAttributes);
            this.Controls.Add(this.GrpbxProject);
            this.Controls.Add(this.PnlBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(255, 210);
            this.Name = "FrmNewProject";
            this.Text = "New Project";
            this.Load += new System.EventHandler(this.FrmNewProject_Load);
            this.PnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxProject.Panel)).EndInit();
            this.GrpbxProject.Panel.ResumeLayout(false);
            this.GrpbxProject.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxProject)).EndInit();
            this.GrpbxProject.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxAttributes.Panel)).EndInit();
            this.GrpbxAttributes.Panel.ResumeLayout(false);
            this.GrpbxAttributes.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrpbxAttributes)).EndInit();
            this.GrpbxAttributes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlBottom;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnOk;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GrpbxProject;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnNavToProgressPaymentsWB;
        private System.Windows.Forms.TextBox TxtProgressPaymentsWorkbookPath;
        private System.Windows.Forms.TextBox TxtProjectName;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox GrpbxAttributes;
        private ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown NUDNoOfLots;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox TxtComments;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}