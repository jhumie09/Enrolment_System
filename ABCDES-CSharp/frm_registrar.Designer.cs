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
            this.pnl_main = new System.Windows.Forms.Panel();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnsubject = new System.Windows.Forms.Button();
            this.btn_student = new System.Windows.Forms.Button();
            this.btn_faculty = new System.Windows.Forms.Button();
            this.pnl_sub_main = new System.Windows.Forms.Panel();
            this.faculty_controler_registar = new ABCDES_CSharp.Faculty_controler();
            this.pnl_main.SuspendLayout();
            this.pnl_sub_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnl_main.Controls.Add(this.btnlogout);
            this.pnl_main.Controls.Add(this.btnProfile);
            this.pnl_main.Controls.Add(this.btnsubject);
            this.pnl_main.Controls.Add(this.btn_student);
            this.pnl_main.Controls.Add(this.btn_faculty);
            this.pnl_main.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_main.Location = new System.Drawing.Point(0, 0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(253, 725);
            this.pnl_main.TabIndex = 0;
            // 
            // btnlogout
            // 
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.FlatAppearance.BorderSize = 2;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(0, 613);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(255, 94);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Logout";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.FlatAppearance.BorderSize = 2;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(0, 142);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(255, 94);
            this.btnProfile.TabIndex = 4;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = true;
            // 
            // btnsubject
            // 
            this.btnsubject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubject.FlatAppearance.BorderSize = 2;
            this.btnsubject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubject.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsubject.ForeColor = System.Drawing.Color.White;
            this.btnsubject.Location = new System.Drawing.Point(-1, 423);
            this.btnsubject.Name = "btnsubject";
            this.btnsubject.Size = new System.Drawing.Size(256, 94);
            this.btnsubject.TabIndex = 3;
            this.btnsubject.Text = "Subject";
            this.btnsubject.UseVisualStyleBackColor = true;
            // 
            // btn_student
            // 
            this.btn_student.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_student.FlatAppearance.BorderSize = 2;
            this.btn_student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_student.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student.ForeColor = System.Drawing.Color.White;
            this.btn_student.Location = new System.Drawing.Point(-1, 330);
            this.btn_student.Name = "btn_student";
            this.btn_student.Size = new System.Drawing.Size(256, 94);
            this.btn_student.TabIndex = 2;
            this.btn_student.Text = "Student";
            this.btn_student.UseVisualStyleBackColor = true;
            // 
            // btn_faculty
            // 
            this.btn_faculty.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_faculty.FlatAppearance.BorderSize = 2;
            this.btn_faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faculty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faculty.ForeColor = System.Drawing.Color.White;
            this.btn_faculty.Location = new System.Drawing.Point(-1, 236);
            this.btn_faculty.Name = "btn_faculty";
            this.btn_faculty.Size = new System.Drawing.Size(256, 94);
            this.btn_faculty.TabIndex = 1;
            this.btn_faculty.Text = "Faculty";
            this.btn_faculty.UseVisualStyleBackColor = true;
            this.btn_faculty.Click += new System.EventHandler(this.btn_faculty_Click);
            // 
            // pnl_sub_main
            // 
            this.pnl_sub_main.BackgroundImage = global::ABCDES_CSharp.Properties.Resources.Front_B;
            this.pnl_sub_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_sub_main.Controls.Add(this.faculty_controler_registar);
            this.pnl_sub_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_sub_main.Location = new System.Drawing.Point(253, 0);
            this.pnl_sub_main.Name = "pnl_sub_main";
            this.pnl_sub_main.Size = new System.Drawing.Size(1041, 725);
            this.pnl_sub_main.TabIndex = 1;
            // 
            // faculty_controler_registar
            // 
            this.faculty_controler_registar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.faculty_controler_registar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faculty_controler_registar.Location = new System.Drawing.Point(0, -4);
            this.faculty_controler_registar.Margin = new System.Windows.Forms.Padding(4);
            this.faculty_controler_registar.Name = "faculty_controler_registar";
            this.faculty_controler_registar.Size = new System.Drawing.Size(1041, 725);
            this.faculty_controler_registar.TabIndex = 0;
            // 
            // frm_registrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1294, 725);
            this.Controls.Add(this.pnl_sub_main);
            this.Controls.Add(this.pnl_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_registrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_main.ResumeLayout(false);
            this.pnl_sub_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnsubject;
        private System.Windows.Forms.Button btn_student;
        private System.Windows.Forms.Button btn_faculty;
        private System.Windows.Forms.Panel pnl_sub_main;
        private Faculty_controler faculty_controler_registar;
    }
}