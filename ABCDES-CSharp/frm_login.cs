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

namespace ABCDES_CSharp
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_username.Clear();
            txt_password.Clear();
            txt_username.Focus();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_username.Text=="admin" && txt_password.Text=="sysadmin")
            {
                Global.AccountType = "admin";
                Global.AccountName = "System Administrator";
                Global.AccountID = "1";

                this.Hide();
                var frm_admin = new frm_admin();
                frm_admin.ShowDialog();
                this.Close();
            }
            else
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                    {
                        conn.Open();
                        string password = Cryptography.Encrypt(txt_password.Text.Trim());
                        string query = "SELECT * from tbl_user where username='" + txt_username.Text.Trim() + "' and password='" + password + "'";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Global.AccountEmp_ID = reader.GetString(1).ToString();
                                    Global.AccountType = reader.GetString(5).ToString();
                                    Global.AccountName = reader.GetString(2).ToString();
                                    Global.AccountID = reader.GetString(0).ToString();
                                    Global.Account_Password = txt_password.Text;

                                    if (Cryptography.Encrypt(Global.AccountEmp_ID) == password)
                                    {
                                        Global.FromLogin = true;
                                        this.Hide();
                                        var frm_change_password = new frm_change_password();
                                        frm_change_password.ShowDialog();
                                        this.Close();
                                    }
                                    else
                                    {
                                        if (Global.AccountType == "Admin")
                                        {
                                            this.Hide();
                                            var frm_admin = new frm_admin();
                                            frm_admin.ShowDialog();
                                            this.Close();
                                        }
                                        else if (Global.AccountType == "Registrar")
                                        {
                                            this.Hide();
                                            var frm_registrar = new frm_registrar();
                                            frm_registrar.ShowDialog();
                                            this.Close();
                                        }
                                    }                                        
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username or password.", "Error");
                                txt_password.Clear();
                                txt_password.Focus();
                            }
                        }                        
                        conn.Close();                        
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }               
            }
        }

        public static bool check_db()
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(Global.MyConn);
                conn.Open();
                conn.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private void frm_login_Load(object sender, EventArgs e)
        {
            set_state();           
        }
        public void set_state()
        {
            bool db_connection = check_db();
            txt_username.Enabled = db_connection;
            txt_password.Enabled = db_connection;
            btn_login.Enabled = db_connection;
            btn_reset.Enabled = db_connection;
            lbl_dbSetUp.Visible = (!db_connection);
        }

        private void lbl_dbSetUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_dbSetup = new frm_dbSetup();
            frm_dbSetup.ShowDialog();
            this.Close();
        }
    }
}
