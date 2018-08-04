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
        }        

        public void clearAccount()
        {
            Global.AccountType = "";
            Global.AccountName = "";
            Global.AccountID = "";
        }

        private void btn_setting_school_year_Click(object sender, EventArgs e)
        {
            var frm_schoolyear = new frm_SchoolYear();
            frm_schoolyear.ShowDialog();
        }

        

        private void frm_registrar_Load(object sender, EventArgs e)
        {
            pnl_control(true, false);
            User_menustrip.Text = Global.AccountName.ToString();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                clearAccount();
                this.Hide();
                var frm_login = new frm_login();
                frm_login.ShowDialog();
                this.Close();
            }
        }

        private void schoolMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnl_control(false, true);
        }

        public void pnl_control(bool defaultpnl,bool sm_pnl)
        {
            default_pnl.Visible = defaultpnl;
            Pnl_SchoolMaintenance.Visible = sm_pnl;
        }
    }
}
