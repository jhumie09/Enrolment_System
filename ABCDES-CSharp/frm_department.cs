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
    public partial class frm_department : Form
    {
        public string Curr_Status="";
        public frm_department()
        {
            InitializeComponent();
        }

        public void Department_list()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_department order by Name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        lst_Department.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lst_Department.Items.Add(reader.GetString(1).ToString());
                            }
                        }
                    }
                    lst_Department.SelectedIndex = -1;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
            
        }        

        public void btn_settings(bool Add,bool Edit,bool Delete,bool Save,bool Cancel)
        {
            btnCancel.Enabled = Cancel;
            btnDelete.Enabled = Delete;
            BtnEdit.Enabled = Edit;
            btnSave.Enabled = Save;
            btn_Add.Enabled = Add;
        }

        public void txt_list_settings(bool search,bool name,bool list_dep)
        {
            txtSearch.Enabled = search;
            txt_Name.Enabled = name;
            lst_Department.Enabled = list_dep;
        }

        private void frm_department_Load(object sender, EventArgs e)
        {
            txt_Name.Clear();
            Department_list();
            txt_list_settings(true, false, true);
            btn_settings(true, false, false, false, false);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            Curr_Status = "add";
            lst_Department.SelectedIndex = -1;
            btn_settings(false, false, false, true, true);
            txt_list_settings(false, true, false);
                      
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (Curr_Status == "add" && txt_Name.Text.Trim()!="")
            {
                msg = Department.Add(txt_Name.Text.Trim());
                MessageBox.Show(msg);
            }
            else if (Curr_Status == "edit" && txt_Name.Text.Trim() != "")
            {
                msg = Department.Edit(lst_Department.SelectedItem.ToString(),txt_Name.Text.Trim());
                MessageBox.Show(msg);
            }

            if (msg.ToLower().Contains("success"))
            {
                txt_Name.Clear();
                btnCancel.PerformClick();
                Department_list();
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lst_Department.Items.Clear();            
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_department where Name like '%" + txtSearch.Text.Trim() + "%' order by Name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lst_Department.Items.Add(reader.GetString(1).ToString());
                            }
                        }
                    }
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            btn_settings(true, false, false, false, false);
            txt_list_settings(true, false, true);
            txt_Name.Clear();
        }

        private void lst_Department_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lst_Department.SelectedIndex>-1)
            {
                txt_Name.Text = lst_Department.SelectedItem.ToString();
                btn_settings(false, true, true, false, true);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
           Curr_Status = "edit";
           btn_settings(false,false,false,true,true);
           txt_list_settings(false, true, false);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msg = "";

            if (txt_Name.Text.Trim() == "")
            {
                MessageBox.Show("Department name is not selected", "Error");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Department?", "Deleting Department", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    msg = Department.Delete(txt_Name.Text.Trim());
                    MessageBox.Show(msg, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                Curr_Status = "delete";
                if (msg.Contains("success"))
                {
                    btn_settings(true, false, false, false, false);
                    txt_list_settings(true, false, true);
                    txt_Name.Clear();
                    Department_list();
                }
                
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txt_Name.Clear();
            lst_Department.SelectedIndex = -1;
            txt_list_settings(true, false, true);
            btn_settings(true, false, false, false, false);
        }
    }
}
