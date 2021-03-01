
namespace PaymentsScheduleTemplateCreator.Forms.FrmOpenProject
{
    partial class FrmOpenProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOpenProject));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.LstRecentProjects = new BrightIdeasSoftware.ObjectListView();
            this.CmsListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TsmiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiCopyPath = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TsmiShowAllProjects = new System.Windows.Forms.ToolStripMenuItem();
            this.PnlLeftTop = new System.Windows.Forms.Panel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.BtnClose = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnNewProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnOpenProject = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LstRecentProjects)).BeginInit();
            this.CmsListView.SuspendLayout();
            this.PnlLeftTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LstRecentProjects);
            this.splitContainer1.Panel1.Controls.Add(this.PnlLeftTop);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.BtnClose);
            this.splitContainer1.Panel2.Controls.Add(this.BtnNewProject);
            this.splitContainer1.Panel2.Controls.Add(this.BtnOpenProject);
            this.splitContainer1.Size = new System.Drawing.Size(996, 506);
            this.splitContainer1.SplitterDistance = 635;
            this.splitContainer1.TabIndex = 0;
            // 
            // LstRecentProjects
            // 
            this.LstRecentProjects.AlternateRowBackColor = System.Drawing.SystemColors.Highlight;
            this.LstRecentProjects.CellEditUseWholeCell = false;
            this.LstRecentProjects.ContextMenuStrip = this.CmsListView;
            this.LstRecentProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.LstRecentProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LstRecentProjects.EmptyListMsg = "Select The \'Create New\' or \'Open Project\' Button To Begin";
            this.LstRecentProjects.Font = new System.Drawing.Font("Axiforma Book", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstRecentProjects.FullRowSelect = true;
            this.LstRecentProjects.HideSelection = false;
            this.LstRecentProjects.Location = new System.Drawing.Point(0, 194);
            this.LstRecentProjects.MultiSelect = false;
            this.LstRecentProjects.Name = "LstRecentProjects";
            this.LstRecentProjects.ShowGroups = false;
            this.LstRecentProjects.ShowItemToolTips = true;
            this.LstRecentProjects.Size = new System.Drawing.Size(635, 312);
            this.LstRecentProjects.TabIndex = 2;
            this.LstRecentProjects.TriggerCellOverEventsWhenOverHeader = false;
            this.LstRecentProjects.UseCompatibleStateImageBehavior = false;
            this.LstRecentProjects.UseHotItem = true;
            this.LstRecentProjects.View = System.Windows.Forms.View.Details;
            this.LstRecentProjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.LstRecentProjects_MouseDoubleClick);
            // 
            // CmsListView
            // 
            this.CmsListView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.CmsListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmiOpen,
            this.TsmiCopyPath,
            this.TsmiRemove,
            this.ToolStripSeparator1,
            this.TsmiShowAllProjects});
            this.CmsListView.Name = "CmsListView";
            this.CmsListView.Size = new System.Drawing.Size(198, 98);
            // 
            // TsmiOpen
            // 
            this.TsmiOpen.Name = "TsmiOpen";
            this.TsmiOpen.Size = new System.Drawing.Size(197, 22);
            this.TsmiOpen.Text = "Open";
            this.TsmiOpen.Click += new System.EventHandler(this.TsmiOpen_Click);
            // 
            // TsmiCopyPath
            // 
            this.TsmiCopyPath.Name = "TsmiCopyPath";
            this.TsmiCopyPath.Size = new System.Drawing.Size(197, 22);
            this.TsmiCopyPath.Text = "Copy path to clipboard";
            this.TsmiCopyPath.Click += new System.EventHandler(this.TsmiCopyPath_Click);
            // 
            // TsmiRemove
            // 
            this.TsmiRemove.Name = "TsmiRemove";
            this.TsmiRemove.Size = new System.Drawing.Size(197, 22);
            this.TsmiRemove.Text = "Remove from list";
            this.TsmiRemove.ToolTipText = "Remove Project From Recents List";
            this.TsmiRemove.Click += new System.EventHandler(this.TsmiRemove_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(194, 6);
            // 
            // TsmiShowAllProjects
            // 
            this.TsmiShowAllProjects.Name = "TsmiShowAllProjects";
            this.TsmiShowAllProjects.Size = new System.Drawing.Size(197, 22);
            this.TsmiShowAllProjects.Text = "List all projects";
            this.TsmiShowAllProjects.Click += new System.EventHandler(this.TsmiShowAllProjects_Click);
            // 
            // PnlLeftTop
            // 
            this.PnlLeftTop.BackColor = System.Drawing.Color.White;
            this.PnlLeftTop.Controls.Add(this.pictureBox1);
            this.PnlLeftTop.Controls.Add(this.kryptonLabel1);
            this.PnlLeftTop.Controls.Add(this.Label2);
            this.PnlLeftTop.Controls.Add(this.Label1);
            this.PnlLeftTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlLeftTop.Location = new System.Drawing.Point(0, 0);
            this.PnlLeftTop.Name = "PnlLeftTop";
            this.PnlLeftTop.Size = new System.Drawing.Size(635, 194);
            this.PnlLeftTop.TabIndex = 1;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(164, 49);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(364, 35);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Green;
            this.kryptonLabel1.StateCommon.ShortText.Color2 = System.Drawing.Color.Green;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Axiforma Book", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 2;
            this.kryptonLabel1.Values.Text = "Progress Payments Editor";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Axiforma Book", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(12, 158);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(152, 33);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Open Recent";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(315, 158);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(235, 22);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "What would you like to do?";
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClose.Location = new System.Drawing.Point(30, 339);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(300, 75);
            this.BtnClose.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnClose.TabIndex = 9;
            this.BtnClose.Values.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Close_Red_48;
            this.BtnClose.Values.Text = "   Exit  ";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnNewProject
            // 
            this.BtnNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNewProject.Location = new System.Drawing.Point(30, 67);
            this.BtnNewProject.Name = "BtnNewProject";
            this.BtnNewProject.Size = new System.Drawing.Size(300, 77);
            this.BtnNewProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnNewProject.TabIndex = 7;
            this.BtnNewProject.Values.ExtraText = "Create Project ";
            this.BtnNewProject.Values.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.New_Blue1_48;
            this.BtnNewProject.Values.Text = "";
            this.BtnNewProject.Click += new System.EventHandler(this.BtnNewProject_Click);
            // 
            // BtnOpenProject
            // 
            this.BtnOpenProject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOpenProject.Location = new System.Drawing.Point(30, 183);
            this.BtnOpenProject.Name = "BtnOpenProject";
            this.BtnOpenProject.Size = new System.Drawing.Size(300, 77);
            this.BtnOpenProject.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BtnOpenProject.TabIndex = 6;
            this.BtnOpenProject.Values.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.Open_Project_48;
            this.BtnOpenProject.Values.Text = " Open Project";
            this.BtnOpenProject.Click += new System.EventHandler(this.BtnOpenProject_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PaymentsScheduleTemplateCreator.Properties.Resources.McKenzie_logo_16;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 117);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FrmOpenProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 506);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOpenProject";
            this.Text = "Open Project";
            this.Load += new System.EventHandler(this.FrmOpenProject_Load);
            this.ResizeEnd += new System.EventHandler(this.FrmOpenProject_ResizeEnd);
            this.SizeChanged += new System.EventHandler(this.FrmOpenProject_SizeChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LstRecentProjects)).EndInit();
            this.CmsListView.ResumeLayout(false);
            this.PnlLeftTop.ResumeLayout(false);
            this.PnlLeftTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private BrightIdeasSoftware.ObjectListView LstRecentProjects;
        internal System.Windows.Forms.Panel PnlLeftTop;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton BtnClose;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton BtnNewProject;
        internal ComponentFactory.Krypton.Toolkit.KryptonButton BtnOpenProject;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.ContextMenuStrip CmsListView;
        internal System.Windows.Forms.ToolStripMenuItem TsmiOpen;
        internal System.Windows.Forms.ToolStripMenuItem TsmiCopyPath;
        internal System.Windows.Forms.ToolStripMenuItem TsmiRemove;
        internal System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        internal System.Windows.Forms.ToolStripMenuItem TsmiShowAllProjects;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
    }
}