
namespace PaymentsScheduleTemplateCreator.Forms.FrmAddSectionItem
{
    partial class FrmAddSectionItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddSectionItem));
            this.TxtItemNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtComment = new System.Windows.Forms.TextBox();
            this.BtnEnter = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.BtnCancel = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSubItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtUnits = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtItemNo
            // 
            this.TxtItemNo.Location = new System.Drawing.Point(12, 28);
            this.TxtItemNo.Name = "TxtItemNo";
            this.TxtItemNo.Size = new System.Drawing.Size(48, 20);
            this.TxtItemNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtDescription.Location = new System.Drawing.Point(12, 118);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(236, 60);
            this.TxtDescription.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Qty";
            // 
            // TxtQty
            // 
            this.TxtQty.Location = new System.Drawing.Point(13, 70);
            this.TxtQty.Name = "TxtQty";
            this.TxtQty.Size = new System.Drawing.Size(47, 20);
            this.TxtQty.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Comment";
            // 
            // TxtComment
            // 
            this.TxtComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtComment.Location = new System.Drawing.Point(12, 200);
            this.TxtComment.Multiline = true;
            this.TxtComment.Name = "TxtComment";
            this.TxtComment.Size = new System.Drawing.Size(236, 62);
            this.TxtComment.TabIndex = 5;
            // 
            // BtnEnter
            // 
            this.BtnEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEnter.Location = new System.Drawing.Point(158, 280);
            this.BtnEnter.Name = "BtnEnter";
            this.BtnEnter.Size = new System.Drawing.Size(90, 25);
            this.BtnEnter.TabIndex = 6;
            this.BtnEnter.Values.Text = "Enter";
            this.BtnEnter.Click += new System.EventHandler(this.BtnEnter_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCancel.Location = new System.Drawing.Point(12, 280);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(90, 25);
            this.BtnCancel.TabIndex = 7;
            this.BtnCancel.Values.Text = "Cancel";
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.ProfessionalSystem;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sub Item";
            // 
            // TxtSubItem
            // 
            this.TxtSubItem.Location = new System.Drawing.Point(95, 28);
            this.TxtSubItem.Name = "TxtSubItem";
            this.TxtSubItem.Size = new System.Drawing.Size(48, 20);
            this.TxtSubItem.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(97, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Units";
            // 
            // TxtUnits
            // 
            this.TxtUnits.Location = new System.Drawing.Point(97, 70);
            this.TxtUnits.Name = "TxtUnits";
            this.TxtUnits.Size = new System.Drawing.Size(47, 20);
            this.TxtUnits.TabIndex = 3;
            // 
            // FrmAddSectionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 317);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtUnits);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtSubItem);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnEnter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtComment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtItemNo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(272, 320);
            this.Name = "FrmAddSectionItem";
            this.Text = "Add Section Item";
            this.Load += new System.EventHandler(this.FrmAddSectionItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtItemNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtComment;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnEnter;
        private ComponentFactory.Krypton.Toolkit.KryptonButton BtnCancel;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtSubItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtUnits;
    }
}