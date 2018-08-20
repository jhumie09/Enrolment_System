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
    public partial class frm_GradeLevel : Form
    {
        string current_event = "";

        public frm_GradeLevel()
        {
            InitializeComponent();
        }

        private void frm_GradeLevel_Load(object sender, EventArgs e)
        {
            txtSearch.Clear();
            txt_Name.Clear();
            txtSearch.Focus();
            grade_level_list(txtSearch.Text);           
            txt_list_settings(true, false, true);
            btn_setup(true, false, false, false, false);
        }

        public void btn_setup(bool Add, bool Edit, bool Delete, bool Save, bool Cancel)
        {
            btnCancel.Enabled = Cancel;
            btnDelete.Enabled = Delete;
            BtnEdit.Enabled = Edit;
            btnSave.Enabled = Save;
            btn_Add.Enabled = Add;
        }

        public void txt_list_settings(bool search, bool name, bool list_grade_level)
        {
            txtSearch.Enabled = search;
            txt_Name.Enabled = name;
            lst_GradeLevel.Enabled = list_grade_level;
        }

        private void lst_GradeLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_GradeLevel.SelectedIndex > -1)
            {
                txt_Name.Text = lst_GradeLevel.SelectedItem.ToString();
                btn_setup(false, true, true, false, true);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            grade_level_list(txtSearch.Text);
            txt_list_settings(true, false, true);
            btn_setup(true, false, false, false, false);
            txt_Name.Clear();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lst_GradeLevel.SelectedIndex = -1;
            current_event = "add";
            btn_setup(false, false, false, true, true);
            txt_list_settings(false, true, false);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            current_event = "edit";
            btn_setup(false, false, false, true, true);
            txt_list_settings(false, true, false);
            txtSearch.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Grade level?", "Deleting Grade Level", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string msg=GradeLevel.Delete(txt_Name.Text.Trim());
                if (msg.Contains("success"))
                {
                    MessageBox.Show(msg, "Deleted");
                }
            }
        }

        public void grade_level_list(string name)
        {
            lst_GradeLevel.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_gradelevel where Name like '%" + txtSearch.Text.Trim() + "%' order by Name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lst_GradeLevel.Items.Add(reader.GetString(1).ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            current_event = "";
            txt_Name.Clear();
            txtSearch.Clear();
            lst_GradeLevel.SelectedIndex = -1;
            grade_level_list(txtSearch.Text);
            txt_list_settings(true, false, true);
            btn_setup(true, false, false, false, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (Isvalid(txt_Name.Text.Trim()) && txt_Name.Text.Trim()!="")
            {
                if (current_event == "add")
                {
                    msg = GradeLevel.Add(txt_Name.Text.Trim());
                }
                else if (current_event == "edit")
                {
                    msg = GradeLevel.Edit(lst_GradeLevel.SelectedItem.ToString(), txt_Name.Text.Trim());
                }

                MessageBox.Show(msg, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (msg.Contains("success"))
                {
                    current_event = "";
                    txt_Name.Clear();
                    txtSearch.Clear();
                    lst_GradeLevel.SelectedIndex = -1;
                    grade_level_list("");
                    txt_list_settings(true, false, true);
                    btn_setup(true, false, false, false, false);
                }
            }
            else
            {
                MessageBox.Show("Invalid grade level name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public bool Isvalid(string name)
        {
            if (current_event == "add")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                    {
                        conn.Open();
                        string query = "SELECT * from tbl_gradelevel where Name='" + name + "'";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }                        
                    }                            
                }
                catch(Exception)
                {
                    return false;
                }                
            }
            else if (current_event == "edit")
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                    {
                        conn.Open();
                        string query = "SELECT * from tbl_gradelevel where ucase(Name)='" + name.ToUpper() + "' and ucase(Name)!='"+lst_GradeLevel.SelectedItem.ToString().ToUpper()+"'";
                        MySqlCommand command = new MySqlCommand(query, conn);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }            
        }
    }
}
