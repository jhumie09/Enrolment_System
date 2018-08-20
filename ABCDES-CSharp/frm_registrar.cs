using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCDES_CSharp
{
    public partial class frm_registrar : Form
    {
        public frm_registrar()
        {
            InitializeComponent();            
            faculty_controler_registar.Visible = false;
        }

        private void btn_faculty_Click(object sender, EventArgs e)
        {           
            faculty_controler_registar.BringToFront();
            faculty_controler_registar.Visible = true;
            Btn_control(false, true, false, false);
        }

        public void btn_mycontrol()
        {
           
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you wan't to logout?","Confirm",MessageBoxButtons.YesNo);

            if (result==DialogResult.Yes)
            {
                this.Hide();
                var frm_login = new frm_login();
                frm_login.ShowDialog();
                this.Close();
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            Btn_control(true, false, false, false);
        }

        public void Btn_control(bool profile,bool faculty,bool student,bool subject)
        {
            btnProfile.BackColor = Color.Gray;
            btn_faculty.BackColor = Color.Gray;
            btn_student.BackColor = Color.Gray;
            btnsubject.BackColor = Color.Gray;

            if (profile)
            {
                btnProfile.BackColor = Color.Silver;
            }
            else if (faculty)
            {
                btn_faculty.BackColor = Color.Silver;
            }
            else if (student)
            {
                btn_student.BackColor = Color.Silver;
            }
            else if (subject)
            {
                btnsubject.BackColor = Color.Silver;
            }
        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            Btn_control(false, false, true, false);
        }

        private void btnsubject_Click(object sender, EventArgs e)
        {
            Btn_control(false, false, false, true);
        }
    }
}
