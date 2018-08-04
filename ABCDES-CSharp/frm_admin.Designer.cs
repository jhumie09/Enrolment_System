namespace ABCDES_CSharp
{
    partial class frm_admin
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
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_department = new System.Windows.Forms.Button();
            this.btn_gradelevel = new System.Windows.Forms.Button();
            this.btnSchoolYear = new System.Windows.Forms.Button();
            this.btn_ChangePass = new System.Windows.Forms.Button();
            this.btn_Section = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_user
            // 
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.Location = new System.Drawing.Point(16, 15);
            this.btn_user.Margin = new System.Windows.Forms.Padding(4);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(169, 87);
            this.btn_user.TabIndex = 0;
            this.btn_user.Text = "User Account";
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.Location = new System.Drawing.Point(196, 164);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(4);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(169, 33);
            this.btn_logout.TabIndex = 1;
            this.btn_logout.Text = "Logout";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_department
            // 
            this.btn_department.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_department.Location = new System.Drawing.Point(16, 110);
            this.btn_department.Margin = new System.Windows.Forms.Padding(4);
            this.btn_department.Name = "btn_department";
            this.btn_department.Size = new System.Drawing.Size(169, 87);
            this.btn_department.TabIndex = 2;
            this.btn_department.Text = "Department";
            this.btn_department.UseVisualStyleBackColor = true;
            this.btn_department.Click += new System.EventHandler(this.btn_department_Click);
            // 
            // btn_gradelevel
            // 
            this.btn_gradelevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gradelevel.Location = new System.Drawing.Point(196, 15);
            this.btn_gradelevel.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gradelevel.Name = "btn_gradelevel";
            this.btn_gradelevel.Size = new System.Drawing.Size(169, 87);
            this.btn_gradelevel.TabIndex = 3;
            this.btn_gradelevel.Text = "Grade Level";
            this.btn_gradelevel.UseVisualStyleBackColor = true;
            this.btn_gradelevel.Click += new System.EventHandler(this.btn_gradelevel_Click);
            // 
            // btnSchoolYear
            // 
            this.btnSchoolYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSchoolYear.Location = new System.Drawing.Point(373, 15);
            this.btnSchoolYear.Margin = new System.Windows.Forms.Padding(4);
            this.btnSchoolYear.Name = "btnSchoolYear";
            this.btnSchoolYear.Size = new System.Drawing.Size(169, 87);
            this.btnSchoolYear.TabIndex = 4;
            this.btnSchoolYear.Text = "School Year";
            this.btnSchoolYear.UseVisualStyleBackColor = true;
            this.btnSchoolYear.Click += new System.EventHandler(this.btnSchoolYear_Click);
            // 
            // btn_ChangePass
            // 
            this.btn_ChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChangePass.Location = new System.Drawing.Point(196, 108);
            this.btn_ChangePass.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ChangePass.Name = "btn_ChangePass";
            this.btn_ChangePass.Size = new System.Drawing.Size(169, 48);
            this.btn_ChangePass.TabIndex = 5;
            this.btn_ChangePass.Text = "Change Password";
            this.btn_ChangePass.UseVisualStyleBackColor = true;
            this.btn_ChangePass.Click += new System.EventHandler(this.btn_ChangePass_Click);
            // 
            // btn_Section
            // 
            this.btn_Section.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Section.Location = new System.Drawing.Point(373, 110);
            this.btn_Section.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Section.Name = "btn_Section";
            this.btn_Section.Size = new System.Drawing.Size(169, 87);
            this.btn_Section.TabIndex = 6;
            this.btn_Section.Text = "Section";
            this.btn_Section.UseVisualStyleBackColor = true;
            this.btn_Section.Click += new System.EventHandler(this.btn_Section_Click);
            // 
            // frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 242);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Section);
            this.Controls.Add(this.btn_ChangePass);
            this.Controls.Add(this.btnSchoolYear);
            this.Controls.Add(this.btn_gradelevel);
            this.Controls.Add(this.btn_department);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_user);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_admin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "System Admin";
            this.Load += new System.EventHandler(this.frm_admin_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_department;
        private System.Windows.Forms.Button btn_gradelevel;
        private System.Windows.Forms.Button btnSchoolYear;
        private System.Windows.Forms.Button btn_ChangePass;
        private System.Windows.Forms.Button btn_Section;
    }
}