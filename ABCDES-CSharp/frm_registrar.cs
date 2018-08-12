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
    }
}
