namespace ABCDES_CSharp
{
    partial class frm_registrar
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
            this.Pnl_SchoolMaintenance = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sm_add = new System.Windows.Forms.Button();
            this.btn_sm_edit = new System.Windows.Forms.Button();
            this.btn_sm_delete = new System.Windows.Forms.Button();
            this.btn_sm_cancel = new System.Windows.Forms.Button();
            this.btn_sm_save = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schoolMaintenanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facultyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.User_menustrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.default_pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_SchoolMaintenance.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.default_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_SchoolMaintenance
            // 
            this.Pnl_SchoolMaintenance.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Pnl_SchoolMaintenance.Controls.Add(this.default_pnl);
            this.Pnl_SchoolMaintenance.Controls.Add(this.btn_sm_save);
            this.Pnl_SchoolMaintenance.Controls.Add(this.btn_sm_cancel);
            this.Pnl_SchoolMaintenance.Controls.Add(this.btn_sm_delete);
            this.Pnl_SchoolMaintenance.Controls.Add(this.btn_sm_edit);
            this.Pnl_SchoolMaintenance.Controls.Add(this.btn_sm_add);
            this.Pnl_SchoolMaintenance.Controls.Add(this.label1);
            this.Pnl_SchoolMaintenance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_SchoolMaintenance.Location = new System.Drawing.Point(0, 28);
            this.Pnl_SchoolMaintenance.Name = "Pnl_SchoolMaintenance";
            this.Pnl_SchoolMaintenance.Size = new System.Drawing.Size(1063, 481);
            this.Pnl_SchoolMaintenance.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(337, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Maintenance";
            // 
            // btn_sm_add
            // 
            this.btn_sm_add.Location = new System.Drawing.Point(15, 116);
            this.btn_sm_add.Name = "btn_sm_add";
            this.btn_sm_add.Size = new System.Drawing.Size(106, 31);
            this.btn_sm_add.TabIndex = 1;
            this.btn_sm_add.Text = "Add";
            this.btn_sm_add.UseVisualStyleBackColor = true;
            // 
            // btn_sm_edit
            // 
            this.btn_sm_edit.Location = new System.Drawing.Point(15, 153);
            this.btn_sm_edit.Name = "btn_sm_edit";
            this.btn_sm_edit.Size = new System.Drawing.Size(106, 31);
            this.btn_sm_edit.TabIndex = 2;
            this.btn_sm_edit.Text = "Edit";
            this.btn_sm_edit.UseVisualStyleBackColor = true;
            // 
            // btn_sm_delete
            // 
            this.btn_sm_delete.Location = new System.Drawing.Point(15, 190);
            this.btn_sm_delete.Name = "btn_sm_delete";
            this.btn_sm_delete.Size = new System.Drawing.Size(106, 31);
            this.btn_sm_delete.TabIndex = 3;
            this.btn_sm_delete.Text = "Delete";
            this.btn_sm_delete.UseVisualStyleBackColor = true;
            // 
            // btn_sm_cancel
            // 
            this.btn_sm_cancel.Location = new System.Drawing.Point(15, 227);
            this.btn_sm_cancel.Name = "btn_sm_cancel";
            this.btn_sm_cancel.Size = new System.Drawing.Size(106, 31);
            this.btn_sm_cancel.TabIndex = 4;
            this.btn_sm_cancel.Text = "Cancel";
            this.btn_sm_cancel.UseVisualStyleBackColor = true;
            // 
            // btn_sm_save
            // 
            this.btn_sm_save.Location = new System.Drawing.Point(15, 264);
            this.btn_sm_save.Name = "btn_sm_save";
            this.btn_sm_save.Size = new System.Drawing.Size(106, 31);
            this.btn_sm_save.TabIndex = 5;
            this.btn_sm_save.Text = "Save";
            this.btn_sm_save.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.User_menustrip,
            this.schoolMaintenanceToolStripMenuItem,
            this.facultyToolStripMenuItem,
            this.studentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schoolMaintenanceToolStripMenuItem
            // 
            this.schoolMaintenanceToolStripMenuItem.Name = "schoolMaintenanceToolStripMenuItem";
            this.schoolMaintenanceToolStripMenuItem.Size = new System.Drawing.Size(155, 24);
            this.schoolMaintenanceToolStripMenuItem.Text = "School Maintenance";
            this.schoolMaintenanceToolStripMenuItem.Click += new System.EventHandler(this.schoolMaintenanceToolStripMenuItem_Click);
            // 
            // facultyToolStripMenuItem
            // 
            this.facultyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.facultyToolStripMenuItem.Name = "facultyToolStripMenuItem";
            this.facultyToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.facultyToolStripMenuItem.Text = "Faculty";
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.informationToolStripMenuItem.Text = "Information";
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(221, 26);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            // 
            // User_menustrip
            // 
            this.User_menustrip.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.User_menustrip.Name = "User_menustrip";
            this.User_menustrip.Size = new System.Drawing.Size(108, 24);
            this.User_menustrip.Text = "User Account";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // default_pnl
            // 
            this.default_pnl.BackColor = System.Drawing.SystemColors.ControlDark;
            this.default_pnl.Controls.Add(this.label2);
            this.default_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.default_pnl.Location = new System.Drawing.Point(0, 0);
            this.default_pnl.Name = "default_pnl";
            this.default_pnl.Size = new System.Drawing.Size(1063, 481);
            this.default_pnl.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(440, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "School Name";
            // 
            // frm_registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1063, 509);
            this.Controls.Add(this.Pnl_SchoolMaintenance);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_registrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar";
            this.Load += new System.EventHandler(this.frm_registrar_Load);
            this.Pnl_SchoolMaintenance.ResumeLayout(false);
            this.Pnl_SchoolMaintenance.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.default_pnl.ResumeLayout(false);
            this.default_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_SchoolMaintenance;
        private System.Windows.Forms.Button btn_sm_save;
        private System.Windows.Forms.Button btn_sm_cancel;
        private System.Windows.Forms.Button btn_sm_delete;
        private System.Windows.Forms.Button btn_sm_edit;
        private System.Windows.Forms.Button btn_sm_add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem User_menustrip;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schoolMaintenanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facultyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.Panel default_pnl;
        private System.Windows.Forms.Label label2;
    }
}