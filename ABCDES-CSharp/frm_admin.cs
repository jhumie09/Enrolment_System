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
    public partial class frm_admin : Form
    {
        public frm_admin()
        {
            InitializeComponent();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?","Logout",MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                clearAccount();
                this.Hide();
                var frm_login = new frm_login();
                frm_login.ShowDialog();
                this.Close();
            }
        }

        public void clearAccount()
        {
            Global.AccountType = "";
            Global.AccountName = "";
            Global.AccountID = "";
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            var frm_UserAccount = new frm_UserAccount();
            frm_UserAccount.ShowDialog();
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            var frm_department = new frm_department();
            frm_department.ShowDialog();
        }

        private void btn_gradelevel_Click(object sender, EventArgs e)
        {
            var frm_gradelevel = new frm_GradeLevel();
            frm_gradelevel.ShowDialog();
        }

        private void frm_admin_Load(object sender, EventArgs e)
        {
            if (Global.AccountID == "1")
            {
                btn_ChangePass.Enabled = false;
            }
        }

        private void btnSchoolYear_Click(object sender, EventArgs e)
        {
            var frm_schoolyear = new frm_SchoolYear();
            frm_schoolyear.ShowDialog();
        }

        private void btn_ChangePass_Click(object sender, EventArgs e)
        {
            var frm_changepass = new frm_change_password();
            frm_changepass.ShowDialog();
        }

        private void btn_Section_Click(object sender, EventArgs e)
        {
            var frm_section = new frm_section();
            frm_section.ShowDialog();
        }
    }
}
