namespace ABCDES_CSharp
{
    partial class Faculty_controler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lst_faculty = new System.Windows.Forms.ListBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.profile_pic = new System.Windows.Forms.PictureBox();
            this.cmb_department = new System.Windows.Forms.ComboBox();
            this.txt_suffix = new System.Windows.Forms.TextBox();
            this.txt_surname = new System.Windows.Forms.TextBox();
            this.txt_middname = new System.Windows.Forms.TextBox();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.txt_emp_no = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faculty Information";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1041, 100);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lst_faculty);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 625);
            this.panel2.TabIndex = 2;
            // 
            // lst_faculty
            // 
            this.lst_faculty.FormattingEnabled = true;
            this.lst_faculty.ItemHeight = 22;
            this.lst_faculty.Location = new System.Drawing.Point(7, 46);
            this.lst_faculty.Name = "lst_faculty";
            this.lst_faculty.Size = new System.Drawing.Size(282, 554);
            this.lst_faculty.TabIndex = 2;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(68, 10);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(221, 30);
            this.txt_search.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Search:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.profile_pic);
            this.groupBox1.Controls.Add(this.cmb_department);
            this.groupBox1.Controls.Add(this.txt_suffix);
            this.groupBox1.Controls.Add(this.txt_surname);
            this.groupBox1.Controls.Add(this.txt_middname);
            this.groupBox1.Controls.Add(this.txt_fname);
            this.groupBox1.Controls.Add(this.txt_emp_no);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl_id);
            this.groupBox1.Location = new System.Drawing.Point(320, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 422);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Information";
            // 
            // profile_pic
            // 
            this.profile_pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profile_pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profile_pic.Location = new System.Drawing.Point(454, 29);
            this.profile_pic.Name = "profile_pic";
            this.profile_pic.Size = new System.Drawing.Size(223, 156);
            this.profile_pic.TabIndex = 29;
            this.profile_pic.TabStop = false;
            // 
            // cmb_department
            // 
            this.cmb_department.FormattingEnabled = true;
            this.cmb_department.Location = new System.Drawing.Point(179, 364);
            this.cmb_department.Name = "cmb_department";
            this.cmb_department.Size = new System.Drawing.Size(228, 30);
            this.cmb_department.TabIndex = 28;
            // 
            // txt_suffix
            // 
            this.txt_suffix.Location = new System.Drawing.Point(179, 307);
            this.txt_suffix.Name = "txt_suffix";
            this.txt_suffix.Size = new System.Drawing.Size(228, 30);
            this.txt_suffix.TabIndex = 27;
            // 
            // txt_surname
            // 
            this.txt_surname.Location = new System.Drawing.Point(179, 246);
            this.txt_surname.MaxLength = 50;
            this.txt_surname.Name = "txt_surname";
            this.txt_surname.Size = new System.Drawing.Size(228, 30);
            this.txt_surname.TabIndex = 26;
            // 
            // txt_middname
            // 
            this.txt_middname.Location = new System.Drawing.Point(179, 187);
            this.txt_middname.MaxLength = 50;
            this.txt_middname.Name = "txt_middname";
            this.txt_middname.Size = new System.Drawing.Size(228, 30);
            this.txt_middname.TabIndex = 25;
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(179, 129);
            this.txt_fname.MaxLength = 50;
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(228, 30);
            this.txt_fname.TabIndex = 24;
            // 
            // txt_emp_no
            // 
            this.txt_emp_no.Location = new System.Drawing.Point(179, 77);
            this.txt_emp_no.MaxLength = 20;
            this.txt_emp_no.Name = "txt_emp_no";
            this.txt_emp_no.Size = new System.Drawing.Size(228, 30);
            this.txt_emp_no.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 372);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Department:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 21;
            this.label7.Text = "Suffix:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "Surname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "Middle name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Employee No.:";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(44, 45);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(58, 22);
            this.lbl_id.TabIndex = 16;
            this.lbl_id.Text = "lbl_id";
            this.lbl_id.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(320, 552);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 150);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // Faculty_controler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Faculty_controler";
            this.Size = new System.Drawing.Size(1041, 725);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profile_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lst_faculty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_department;
        private System.Windows.Forms.TextBox txt_suffix;
        private System.Windows.Forms.TextBox txt_surname;
        private System.Windows.Forms.TextBox txt_middname;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.TextBox txt_emp_no;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.PictureBox profile_pic;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
