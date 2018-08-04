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
    public partial class frm_UserAccount : Form
    {
        public frm_UserAccount()
        {
            InitializeComponent();
        }

        private void lbl_Userlist_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                Global.AffectedAccount = lbl_Userlist.SelectedItem.ToString();               
                if (lbl_Userlist.SelectedIndex > -1)
                {
                    btn_settings(false, true, true, false, false, true);
                    txt_lbl_drp_setting(true, true, false, false, false, false);
                    try
                    {
                        using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                        {
                            conn.Open();
                            string query = "SELECT * from tbl_user where id not in (1," + Global.AccountID + ") and Account_name='" + Global.AffectedAccount + "' order by Account_name limit 1";
                            MySqlCommand command = new MySqlCommand(query, conn);
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    while (reader.Read())
                                    {
                                        txt_empId.Text = reader.GetString(1).ToString();
                                        txt_AccountName.Text = reader.GetString(2).ToString();
                                        txt_username.Text = reader.GetString(3).ToString();
                                        cmb_usertype.SelectedItem = reader.GetString(5).ToString();
                                    }
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
            catch (Exception)
            {

            }
            
            
            
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            lbl_Userlist.SelectedIndex = -1;
            Global_Account_SetUp(true, false, false, false);
            btn_settings(false,false,false,true,true,false);
            txt_lbl_drp_setting(false,false,true,true,true,true);
            txt_empId.Focus();
        }

        private void frm_UserAccount_Load(object sender, EventArgs e)
        {
            Load_Account_list();
        }

        public void Load_Account_list()
        {           
            try
            {               
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "SELECT * from tbl_user where id not in (1,"+Global.AccountID+ ") order by Account_name";
                    MySqlCommand command = new MySqlCommand(query,conn);
                    using(MySqlDataReader reader=command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            lbl_Userlist.Items.Clear();
                            while (reader.Read())
                            {
                                lbl_Userlist.Items.Add(reader.GetString(2).ToString());                                
                            }
                        }
                    }
                    btn_settings(true, false, false, false, false, false);
                    txt_lbl_drp_setting(true, true, false, false, false, false);
                    lbl_Userlist.SelectedIndex = -1;
                    txt_AccountName.Clear();
                    txt_empId.Clear();
                    txt_username.Clear();
                    cmb_usertype.SelectedIndex = -1;
                    conn.Close();

                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void btn_settings(bool btn_add_enable,bool btn_edit_enable,bool btn_delete_enable,bool btn_cancel_enable,bool btn_save_enable,bool btn_resetP_enable)
        {
            btn_Add.Enabled = btn_add_enable;
            btn_Edit.Enabled = btn_edit_enable;
            btn_delete.Enabled = btn_delete_enable;
            btn_cancel.Enabled = btn_cancel_enable;
            btn_save.Enabled = btn_save_enable;
            btn_reset_password.Enabled = btn_resetP_enable;
        }

        public void txt_lbl_drp_setting(bool txt_Search_enable,bool lbl_list_enable,bool txt_emp_enable,bool txt_AccountName_enable,bool txt_username_enable,bool drp_usertype_enable)
        {
            txtSearch.Enabled = txt_Search_enable;
            lbl_Userlist.Enabled = lbl_list_enable;
            txt_empId.Enabled = txt_emp_enable;
            txt_AccountName.Enabled = txt_AccountName_enable;
            txt_username.Enabled = txt_username_enable;
            cmb_usertype.Enabled = drp_usertype_enable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "SELECT * from tbl_user WHERE Account_name like '%"+txtSearch.Text.Trim()+ "%' and id not in (1," + Global.AccountID + ") order by Account_name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        lbl_Userlist.Items.Clear();
                        if (reader.HasRows)
                        {                            
                            while (reader.Read())
                            {
                                lbl_Userlist.Items.Add(reader.GetString(2).ToString());
                            }
                        }
                    }
                    conn.Close();
                }
                btn_settings(true, false, false, false, false, false);
                txt_lbl_drp_setting(true, true, false, false, false, false);
                lbl_Userlist.SelectedIndex = -1;
                txt_AccountName.Clear();
                txt_empId.Clear();
                txt_username.Clear();
                cmb_usertype.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            btn_settings(false,false,false,true,true,false);
            Global_Account_SetUp(false, true, false, false);
            txt_lbl_drp_setting(false, false, true, true, true, true);
            Global.AffectedAccount = lbl_Userlist.SelectedItem.ToString();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_empId.Text.Trim()=="")
            {
                MessageBox.Show("Invalid Employee ID","Error");
                txt_empId.Focus();
            }
            else if (txt_AccountName.Text.Trim()=="")
            {
                MessageBox.Show("Invalid Account Name", "Error");
                txt_AccountName.Focus();
            }
            else if (txt_username.Text.Trim()=="")
            {
                MessageBox.Show("Invalid Username", "Error");
                txt_username.Focus();
            }
            else if (cmb_usertype.SelectedItem.ToString().Trim()=="")
            {
                MessageBox.Show("Invalid Usertype", "Error");
                cmb_usertype.Focus();
            }
            else
            {
                if (Global.AddAccount)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to add this Account?", "Adding Account", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                            {
                                conn.Open();
                                string query = "SELECT * from tbl_user where Emp_id='" + txt_empId.Text + "' or Account_name='" + txt_AccountName.Text + "' or username='" + txt_username.Text + "' order by Account_name";
                                MySqlCommand command = new MySqlCommand(query, conn);
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        MessageBox.Show("Employee Id or Account name is already exist or username is alredy used by other account", "Conplict");
                                    }
                                    else
                                    {
                                        using (MySqlConnection conn1 = new MySqlConnection(Global.MyConn))
                                        {
                                            conn1.Open();
                                            string password = Cryptography.Encrypt(txt_empId.Text);
                                            string query1 = "Insert into tbl_user(Emp_id,Account_name,username,password,UserType) values ('" + txt_empId.Text + "','" + txt_AccountName.Text + "','" + txt_username.Text + "','" + password + "','" + cmb_usertype.SelectedItem.ToString() + "')";
                                            MySqlCommand command1 = new MySqlCommand(query1, conn1);
                                            command1.ExecuteReader();
                                            conn1.Close();
                                            MessageBox.Show(txt_AccountName.Text + " successfully added.", "Procccess Done");
                                        }
                                    }
                                }
                                conn.Close();
                                Load_Account_list();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                else if (Global.EditAccount)
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this Account?", "Edit Account", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        try
                        {
                            using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                            {
                                conn.Open();
                                string query = "SELECT * from tbl_user where Account_name!='" + Global.AffectedAccount + "' and (Emp_id='" + txt_empId.Text + "' or Account_name='" + txt_AccountName.Text + "' or username='" + txt_username.Text + "') order by Account_name";
                                MySqlCommand command = new MySqlCommand(query, conn);
                                using (MySqlDataReader reader = command.ExecuteReader())
                                {
                                    if (reader.HasRows)
                                    {
                                        MessageBox.Show("Employee Id or Account name is already exist or username is alredy used by other account", "Conplict");
                                    }
                                    else
                                    {
                                        using (MySqlConnection conn1 = new MySqlConnection(Global.MyConn))
                                        {
                                            conn1.Open();
                                            string query1 = "UPDATE tbl_user SET Emp_id='" + txt_empId.Text + "',Account_name='" + txt_AccountName.Text + "',username='" + txt_username.Text + "',UserType='" + cmb_usertype.SelectedItem.ToString() + "' where Account_name='"+Global.AffectedAccount+"'";
                                            MySqlCommand command1 = new MySqlCommand(query1, conn1);
                                            command1.ExecuteReader();
                                            conn1.Close();
                                            MessageBox.Show(Global.AffectedAccount + " Successfully updated.", "Procccess Done");
                                        }
                                    }
                                }
                                conn.Close();
                                Load_Account_list();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            
        }

        public void Global_Account_SetUp(bool add_account,bool edit_account,bool delete_account,bool reset_account)
        {
            Global.AddAccount = add_account;
            Global.EditAccount = edit_account;
            Global.DeleteAccount = delete_account;
            Global.ResetPasswordAccount = reset_account;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_Userlist.SelectedIndex = -1;
            Global_Account_SetUp(false,false,false,false);
            btn_settings(false,false,false,false,false,false);
            txt_lbl_drp_setting(true,true,false,false,false,false);

            txt_empId.Clear();
            txt_AccountName.Clear();
            txtSearch.Clear();
            txt_username.Clear();
            cmb_usertype.SelectedIndex = 0;
            txtSearch.Focus();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Account?", "Deleting Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                    {
                        conn.Open();
                        string query = "DELETE FROM tbl_user where Account_name='" + txt_AccountName.Text + "'";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.ExecuteReader();
                        conn.Close();
                        MessageBox.Show("Delete Successfully");
                        Load_Account_list();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_reset_password_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to reset password of this Account?", "Reset Password", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                    {
                        conn.Open();
                        string password = Cryptography.Encrypt(txt_empId.Text);
                        string query = "UPDATE tbl_user Set password = '"+password+"' where Account_name='" + txt_AccountName.Text + "'";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        command.ExecuteReader();
                        conn.Close();
                        MessageBox.Show("Reset Successfully");
                        Load_Account_list();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
