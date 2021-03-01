
namespace PaymentsScheduleTemplateCreator.Forms.FrmMasterSchedule
{
    partial class FrmMasterSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMasterSchedule));
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.LblClickLink = new System.Windows.Forms.Label();
            this.LnkMasterSchedule = new System.Windows.Forms.LinkLabel();
            this.BtnNavToMasterSchedule = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TxtMasterScheduleFullPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.kryptonGroupBox1.Location = new System.Drawing.Point(12, 10);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.label2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.label1);
            this.kryptonGroupBox1.Panel.Controls.Add(this.LblClickLink);
            this.kryptonGroupBox1.Panel.Controls.Add(this.LnkMasterSchedule);
            this.kryptonGroupBox1.Panel.Controls.Add(this.BtnNavToMasterSchedule);
            this.kryptonGroupBox1.Panel.Controls.Add(this.TxtMasterScheduleFullPath);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(527, 151);
            this.kryptonGroupBox1.TabIndex = 70;
            this.kryptonGroupBox1.Values.Heading = "Master Schedule Workbook";
            // 
            // LblClickLink
            // 
            this.LblClickLink.AutoSize = true;
            this.LblClickLink.BackColor = System.Drawing.Color.Transparent;
            this.LblClickLink.Location = new System.Drawing.Point(178, 100);
            this.LblClickLink.Name = "LblClickLink";
            this.LblClickLink.Size = new System.Drawing.Size(252, 13);
            this.LblClickLink.TabIndex = 69;
            this.LblClickLink.Text = "<<==  Please Click Link To Download From Synergy";
            // 
            // LnkMasterSchedule
            // 
            this.LnkMasterSchedule.AutoSize = true;
            this.LnkMasterSchedule.BackColor = System.Drawing.Color.Transparent;
            this.LnkMasterSchedule.Location = new System.Drawing.Point(15, 100);
            this.LnkMasterSchedule.Name = "LnkMasterSchedule";
            this.LnkMasterSchedule.Size = new System.Drawing.Size(147, 13);
            this.LnkMasterSchedule.TabIndex = 68;
            this.LnkMasterSchedule.TabStop = true;
            this.LnkMasterSchedule.Text = "MCL Master schedule R2.xlsx";
            this.LnkMasterSchedule.Visible = false;
            // 
            // BtnNavToMasterSchedule
            // 
            this.BtnNavToMasterSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNavToMasterSchedule.Location = new System.Drawing.Point(492, 96);
            this.BtnNavToMasterSchedule.Name = "BtnNavToMasterSchedule";
            this.BtnNavToMasterSchedule.Size = new System.Drawing.Size(28, 20);
            this.BtnNavToMasterSchedule.TabIndex = 66;
            this.BtnNavToMasterSchedule.ToolTipValues.Description = "The Master Schedule Workbook is avaliable in Synergy. This document is located in" +
    " the Standard Documents > C_Scheduling Folder in Synergy. Please ensure you have" +
    " downloaded the latest version.";
            this.BtnNavToMasterSchedule.ToolTipValues.EnableToolTips = true;
            this.BtnNavToMasterSchedule.ToolTipValues.Heading = "Master Schedule Workbook";
            this.BtnNavToMasterSchedule.ToolTipValues.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.search_16;
            this.BtnNavToMasterSchedule.Values.Text = "...";
            this.BtnNavToMasterSchedule.Click += new System.EventHandler(this.BtnNavToMasterSchedule_Click);
            // 
            // TxtMasterScheduleFullPath
            // 
            this.TxtMasterScheduleFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtMasterScheduleFullPath.BackColor = System.Drawing.Color.White;
            this.TxtMasterScheduleFullPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMasterScheduleFullPath.ForeColor = System.Drawing.Color.Black;
            this.TxtMasterScheduleFullPath.Location = new System.Drawing.Point(8, 96);
            this.TxtMasterScheduleFullPath.Name = "TxtMasterScheduleFullPath";
            this.TxtMasterScheduleFullPath.Size = new System.Drawing.Size(483, 20);
            this.TxtMasterScheduleFullPath.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Axiforma Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(391, 25);
            this.label2.TabIndex = 71;
            this.label2.Text = "Or Navigate to your Master Schedule Workbook";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Axiforma Book", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "Please Click the Link Below";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(464, 176);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 71;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmMasterSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 211);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.kryptonGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(567, 250);
            this.Name = "FrmMasterSchedule";
            this.Text = "Master Schedule";
            this.Load += new System.EventHandler(this.FrmMasterSchedule_Load);
            this.Shown += new System.EventHandler(this.FrmMasterSchedule_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblClickLink;
        private System.Windows.Forms.LinkLabel LnkMasterSchedule;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnNavToMasterSchedule;
        private System.Windows.Forms.TextBox TxtMasterScheduleFullPath;
        private System.Windows.Forms.Button BtnClose;
    }
}