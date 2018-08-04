using MySql.Data.MySqlClient;
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
    public partial class frm_change_password : Form
    {
        public frm_change_password()
        {
            InitializeComponent();
        }

        private void frm_change_password_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();                    
                    string query = "SELECT * from tbl_user where id='" + Global.AccountID + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lbl_account.Text = reader.GetString(2).ToString();                               
                            }
                        }
                        else
                        {
                            MessageBox.Show("No Record found", "Error");                            
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

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_old_password.Text.Trim()=="")
            {
                MessageBox.Show("Old Password is empty.","Validation");
                txt_old_password.Focus();
            }
            else if(txt_new_password.Text.Trim()=="")
            {
                MessageBox.Show("New Password is empty.", "Validation");
                txt_new_password.Focus();
            }
            else if (txt_v_new_password.Text.Trim()=="")
            {
                MessageBox.Show("Verify Password is empty.", "Validation");
                txt_v_new_password.Focus();
            }
            else if (Cryptography.Encrypt(txt_old_password.Text.Trim())!=Cryptography.Encrypt(Global.Account_Password))
            {
                MessageBox.Show("Incorrect old password.", "Error");
                txt_old_password.Focus();
            }
            else if(txt_old_password.Text.Trim()==txt_new_password.Text.Trim())
            {
                MessageBox.Show("Old password and new password is equal.", "Validation");
                txt_old_password.Focus();
                txt_new_password.Clear();
                txt_v_new_password.Clear();
            }
            else if (txt_new_password.Text.Trim()!=txt_v_new_password.Text.Trim())
            {
                MessageBox.Show("New paassword is not equal to validate password.", "Validation");                
                txt_new_password.Clear();
                txt_v_new_password.Clear();
                txt_new_password.Focus();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to save new password?", "New Password", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                        {
                            conn.Open();
                            string password = Cryptography.Encrypt(txt_new_password.Text.Trim());
                            string query = "UPDATE tbl_user Set password = '" + password + "' where id='" + Global.AccountID + "'";
                            MySqlCommand command = new MySqlCommand(query, conn);
                            command.ExecuteReader();
                            conn.Close();
                            MessageBox.Show("Save Successfully");

                            SetAccount();
                            this.Hide();
                            if (Global.FromLogin)
                            {
                                var frm_login = new frm_login();
                                frm_login.ShowDialog();
                            }
                            

                            this.Close();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        public void SetAccount()
        {
            Global.Account_Password = txt_new_password.Text;
        }
    }
}
