using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ABCDES_CSharp
{
    public partial class frm_dbSetup : Form
    {
        public frm_dbSetup()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_login = new frm_login();
            frm_login.ShowDialog();
            this.Close();
        }

        private void frm_dbSetup_Load(object sender, EventArgs e)
        {
            set_access();
        }
        public void set_access()
        {
            string[] lines = File.ReadAllLines("db_conn.txt");
            txt_Server.Text = lines[0].ToString();
            txt_db.Text = lines[1].ToString();
            txt_username.Text = lines[2].ToString();
            txt_password.Text = lines[3].ToString();
            if(lines[4].ToLower().ToString()=="required")
            {
                Chk_SSLMode.Checked = true;
            }
            else
            {
                Chk_SSLMode.Checked = false;
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
           
            try
            {
                string sslmode = "";
                if (Chk_SSLMode.Checked==true)
                {
                    sslmode = "Required";
                }
                else
                {
                    sslmode = "none";
                }
                string MyConn = "Server=" + txt_Server.Text + ";Database=" + txt_db.Text + ";user id=" + txt_username.Text + ";Password=" + txt_password.Text + ";SslMode="+sslmode;
                MySqlConnection conn = new MySqlConnection(MyConn);
                conn.Open();
                conn.Close();               
                MessageBox.Show("Connected");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {                
                string sslmode = "";
                if (Chk_SSLMode.Checked == true)
                {
                    sslmode = "Required";
                }
                else
                {
                    sslmode = "none";
                }
                string[] lines = File.ReadAllLines("db_conn.txt");
                lines[0] = txt_Server.Text;
                lines[1] = txt_db.Text;
                lines[2] = txt_username.Text;
                lines[3] = txt_password.Text;
                lines[4] = sslmode;
                File.WriteAllLines("db_conn.txt", lines);
                string MyConn = "Server=" + txt_Server.Text + ";Database=" + txt_db.Text + ";user id=" + txt_username.Text + ";Password=" + txt_password.Text + ";SslMode=" + sslmode;
                MySqlConnection conn = new MySqlConnection(MyConn);
                conn.Open();
                conn.Close();
                Global.MyConn = MyConn;
                MessageBox.Show("Saved");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
