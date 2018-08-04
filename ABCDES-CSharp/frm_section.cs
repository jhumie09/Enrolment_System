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
    public partial class frm_section : Form
    {
        public static string curr_process = "";
        public frm_section()
        {
            InitializeComponent();
        }

        public void My_Default_setup()
        {
            txt_Name.Clear();
            txtSearch.Clear();
            txtSearch.Focus();
            TxtNlst_control(true, true, false, false);
            Button_control(true, false, false, false, false);
            Load_year_cmb();
            Load_section_list(txtSearch.Text);
            cmb_Year.SelectedIndex = 0;
        }

        public void Load_year_cmb()
        {
            cmb_Year.Items.Clear();
            cmb_Year.Items.Add("");
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select Name from tbl_gradelevel order by Name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                cmb_Year.Items.Add(reader.GetString(0).ToString());
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

        public void Load_section_list(string name)
        {
            lst_section.Items.Clear();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_section where SecName like '%" + name + "%' order by SecName";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lst_section.Items.Add(reader.GetString(1).ToString());
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

        public void Button_control(bool btnadd,bool btnedit,bool btndelete,bool btncancel,bool btnsave)
        {
            btn_Add.Enabled = btnadd;
            BtnEdit.Enabled = btnedit;
            btnDelete.Enabled = btndelete;
            btnCancel.Enabled = btncancel;
            btnSave.Enabled = btnsave;
        }

        public void TxtNlst_control(bool search,bool seclist,bool secname,bool cmbyear)
        {
            txtSearch.Enabled = search;
            lst_section.Enabled = seclist;
            txt_Name.Enabled = secname;
            cmb_Year.Enabled = cmbyear;
        }

        private void frm_section_Load(object sender, EventArgs e)
        {
            My_Default_setup();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            curr_process = "add";
            txtSearch.Clear();
            txt_Name.Clear();            
            TxtNlst_control(false, false, true, true);
            Button_control(false, false, false, true, true);
            txt_Name.Focus();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            curr_process = "edit";
            txtSearch.Clear();            
            txt_Name.Focus();
            TxtNlst_control(false, false, true, true);
            Button_control(false, false, false, true, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            curr_process = "delete";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this section?", "Deleting section", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string msg = "";
                msg = Section.Delete(lbl_id.Text,Global.AccountID.ToString(),txt_Name.Text.Trim());
                if (msg.Contains("success"))
                {
                    MessageBox.Show(msg, "Deleted");
                    My_Default_setup();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            My_Default_setup();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if (curr_process == "add")
            {
                msg = Section.Add(txt_Name.Text.Trim(), cmb_Year.SelectedItem.ToString(), Global.AccountID.ToString());
            }
            else if (curr_process=="edit")
            {
                msg = Section.Edit(lbl_id.Text, txt_Name.Text.Trim(), cmb_Year.SelectedItem.ToString(), Global.AccountID.ToString());
            }

            MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (msg.Contains("success"))
            {
                My_Default_setup();
            }
        }

        private void lst_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_section where SecName='"+lst_section.SelectedItem.ToString()+"' limit 1";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lbl_id.Text = reader.GetString(0).ToString();
                                txt_Name.Text = reader.GetString(1).ToString();
                                cmb_Year.SelectedItem = reader.GetString(2).ToString();
                            }
                            Button_control(false, true, true, false, false);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {            
            Load_section_list(txtSearch.Text.Trim());
        }
    }
}
