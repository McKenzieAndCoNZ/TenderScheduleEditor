
namespace PaymentsScheduleTemplateCreator.Forms.FrmTest
{
    partial class FrmTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTest));
            this.kryptonHeaderGroup1 = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.kryptonButton1 = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CboMonthlyClaim = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.CboPaymentSchedule = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.BtnNavToProgressPaymentsWB = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtProgressPaymentsWorkbookPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.NavSepPortions = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.BtnSpecAddPage = new ComponentFactory.Krypton.Navigator.ButtonSpecNavigator();
            this.PageSP1 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.PnlButtons = new System.Windows.Forms.Panel();
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCRUD = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).BeginInit();
            this.kryptonHeaderGroup1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboMonthlyClaim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPaymentSchedule)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NavSepPortions)).BeginInit();
            this.NavSepPortions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSP1)).BeginInit();
            this.PnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonHeaderGroup1
            // 
            this.kryptonHeaderGroup1.Location = new System.Drawing.Point(28, 12);
            this.kryptonHeaderGroup1.Name = "kryptonHeaderGroup1";
            this.kryptonHeaderGroup1.Size = new System.Drawing.Size(104, 58);
            this.kryptonHeaderGroup1.TabIndex = 1;
            this.kryptonHeaderGroup1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonHeaderGroup1_Paint);
            this.kryptonHeaderGroup1.DoubleClick += new System.EventHandler(this.kryptonHeaderGroup1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.kryptonButton1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(186, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(143, 53);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Master Schedule Workbook";
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonButton1.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.kryptonButton1.Location = new System.Drawing.Point(112, 19);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.Size = new System.Drawing.Size(28, 20);
            this.kryptonButton1.TabIndex = 64;
            this.kryptonButton1.ToolTipValues.Description = "The Master Schedule Workbook is avaliable in Synergy. This document is located in" +
    " the Standard Documents > C_Scheduling Folder in Synergy. Please ensure you have" +
    " downloaded the latest version.";
            this.kryptonButton1.ToolTipValues.EnableToolTips = true;
            this.kryptonButton1.ToolTipValues.Heading = "Master Schedule Workbook";
            this.kryptonButton1.ToolTipValues.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.search_16;
            this.kryptonButton1.Values.Text = "...";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 63;
            this.textBox1.Text = "<Please Navigate to the Master Schedule Workbook In Synergy>";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CboMonthlyClaim);
            this.groupBox1.Controls.Add(this.CboPaymentSchedule);
            this.groupBox1.Controls.Add(this.BtnNavToProgressPaymentsWB);
            this.groupBox1.Controls.Add(this.TxtProgressPaymentsWorkbookPath);
            this.groupBox1.Location = new System.Drawing.Point(30, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 166);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Progress Payments Workbook";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Latest Monthly Claim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Payment Schedule";
            // 
            // CboMonthlyClaim
            // 
            this.CboMonthlyClaim.DropDownWidth = 316;
            this.CboMonthlyClaim.IntegralHeight = false;
            this.CboMonthlyClaim.Location = new System.Drawing.Point(6, 134);
            this.CboMonthlyClaim.Name = "CboMonthlyClaim";
            this.CboMonthlyClaim.Size = new System.Drawing.Size(316, 21);
            this.CboMonthlyClaim.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CboMonthlyClaim.TabIndex = 67;
            this.CboMonthlyClaim.Text = "<Empty>";
            this.CboMonthlyClaim.ToolTipValues.Description = resources.GetString("resource.Description");
            this.CboMonthlyClaim.ToolTipValues.EnableToolTips = true;
            this.CboMonthlyClaim.ToolTipValues.Heading = "Current Monthly Claim";
            this.CboMonthlyClaim.ToolTipValues.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.search_16;
            // 
            // CboPaymentSchedule
            // 
            this.CboPaymentSchedule.DropDownWidth = 316;
            this.CboPaymentSchedule.IntegralHeight = false;
            this.CboPaymentSchedule.Location = new System.Drawing.Point(6, 72);
            this.CboPaymentSchedule.Name = "CboPaymentSchedule";
            this.CboPaymentSchedule.Size = new System.Drawing.Size(316, 21);
            this.CboPaymentSchedule.StateCommon.ComboBox.Content.TextH = ComponentFactory.Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.CboPaymentSchedule.TabIndex = 66;
            this.CboPaymentSchedule.Text = "<Empty>";
            this.CboPaymentSchedule.ToolTipValues.Description = resources.GetString("resource.Description1");
            this.CboPaymentSchedule.ToolTipValues.EnableToolTips = true;
            this.CboPaymentSchedule.ToolTipValues.Heading = "Payment Schedule";
            this.CboPaymentSchedule.ToolTipValues.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.search_16;
            // 
            // BtnNavToProgressPaymentsWB
            // 
            this.BtnNavToProgressPaymentsWB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNavToProgressPaymentsWB.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.NavigatorStack;
            this.BtnNavToProgressPaymentsWB.Location = new System.Drawing.Point(328, 19);
            this.BtnNavToProgressPaymentsWB.Name = "BtnNavToProgressPaymentsWB";
            this.BtnNavToProgressPaymentsWB.Size = new System.Drawing.Size(28, 20);
            this.BtnNavToProgressPaymentsWB.TabIndex = 65;
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
            this.TxtProgressPaymentsWorkbookPath.Location = new System.Drawing.Point(6, 19);
            this.TxtProgressPaymentsWorkbookPath.Name = "TxtProgressPaymentsWorkbookPath";
            this.TxtProgressPaymentsWorkbookPath.Size = new System.Drawing.Size(316, 20);
            this.TxtProgressPaymentsWorkbookPath.TabIndex = 64;
            this.TxtProgressPaymentsWorkbookPath.Text = "<Please Navigate To Your Emtpy Progress Payments Workbook>";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.NavSepPortions);
            this.groupBox3.Location = new System.Drawing.Point(53, 254);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(872, 341);
            this.groupBox3.TabIndex = 67;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
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
            this.NavSepPortions.Button.CloseButton.ToolTipImage = global::PaymentsScheduleTemplateCreator.Properties.Resources.Minus_16;
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
            this.NavSepPortions.Location = new System.Drawing.Point(195, 47);
            this.NavSepPortions.Name = "NavSepPortions";
            this.NavSepPortions.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.PageSP1});
            this.NavSepPortions.SelectedIndex = 0;
            this.NavSepPortions.Size = new System.Drawing.Size(482, 246);
            this.NavSepPortions.TabIndex = 2;
            this.NavSepPortions.Text = "kryptonNavigator1";
            // 
            // BtnSpecAddPage
            // 
            this.BtnSpecAddPage.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.add_page_16;
            this.BtnSpecAddPage.Text = "Add New";
            this.BtnSpecAddPage.ToolTipBody = "Add a new Separable Portion";
            this.BtnSpecAddPage.ToolTipTitle = "Add New";
            this.BtnSpecAddPage.UniqueName = "ae47b04fbec74fb0bc36e42956e91434";
            // 
            // PageSP1
            // 
            this.PageSP1.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.PageSP1.Flags = 65534;
            this.PageSP1.LastVisibleSet = true;
            this.PageSP1.MinimumSize = new System.Drawing.Size(50, 50);
            this.PageSP1.Name = "PageSP1";
            this.PageSP1.Size = new System.Drawing.Size(480, 216);
            this.PageSP1.Text = "Separable Portion 1";
            this.PageSP1.ToolTipTitle = "Page ToolTip";
            this.PageSP1.UniqueName = "8f8f8c6d09f04380b5a1ac79f4d16fbf";
            // 
            // PnlButtons
            // 
            this.PnlButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlButtons.Controls.Add(this.BtnCancel);
            this.PnlButtons.Controls.Add(this.BtnCRUD);
            this.PnlButtons.Location = new System.Drawing.Point(487, 103);
            this.PnlButtons.Name = "PnlButtons";
            this.PnlButtons.Size = new System.Drawing.Size(332, 37);
            this.PnlButtons.TabIndex = 68;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(90, 5);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 25);
            this.BtnCancel.TabIndex = 21;
            this.BtnCancel.Values.Text = "Cancel";
            // 
            // BtnCRUD
            // 
            this.BtnCRUD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCRUD.Location = new System.Drawing.Point(196, 5);
            this.BtnCRUD.Name = "BtnCRUD";
            this.BtnCRUD.Size = new System.Drawing.Size(120, 25);
            this.BtnCRUD.TabIndex = 20;
            this.BtnCRUD.ToolTipValues.Description = "All Separable Portions in this form will be added to the selected workbook.";
            this.BtnCRUD.ToolTipValues.EnableToolTips = true;
            this.BtnCRUD.ToolTipValues.Heading = "Update Workbook";
            this.BtnCRUD.ToolTipValues.Image = null;
            this.BtnCRUD.Values.Text = "Update Workbook";
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 557);
            this.Controls.Add(this.PnlButtons);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.kryptonHeaderGroup1);
            this.Name = "FrmTest";
            this.Text = "FrmTest";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1.Panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonHeaderGroup1)).EndInit();
            this.kryptonHeaderGroup1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CboMonthlyClaim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPaymentSchedule)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NavSepPortions)).EndInit();
            this.NavSepPortions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PageSP1)).EndInit();
            this.PnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kryptonHeaderGroup1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CboMonthlyClaim;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CboPaymentSchedule;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnNavToProgressPaymentsWB;
        private System.Windows.Forms.TextBox TxtProgressPaymentsWorkbookPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator NavSepPortions;
        private ComponentFactory.Krypton.Navigator.ButtonSpecNavigator BtnSpecAddPage;
        private ComponentFactory.Krypton.Navigator.KryptonPage PageSP1;
        private System.Windows.Forms.Panel PnlButtons;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCRUD;
    }
}