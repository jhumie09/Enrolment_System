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
    public partial class frm_SchoolYear : Form
    {
        string current_action = "";
        public frm_SchoolYear()
        {
            InitializeComponent();
        }
        public void Get_schoolyear(string schoolyear)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Select * from tbl_schoolyear where name like '%"+txtSearch.Text.Trim()+"%' order by Name";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        lst_schoolyear.Items.Clear();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                lst_schoolyear.Items.Add(reader.GetString(1).ToString());
                            }
                        }
                    }
                    lst_schoolyear.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void txt_lst_enable_disable(bool search,bool LstSchoolYear,bool name)
        {
            txtSearch.Enabled = search;
            lst_schoolyear.Enabled = LstSchoolYear;
            txt_Name.Enabled = name;
        }
        public void btn_setup(bool add,bool edit,bool delete,bool cancel,bool save)
        {
            btn_Add.Enabled = add;
            BtnEdit.Enabled = edit;
            btnDelete.Enabled = delete;
            btnCancel.Enabled = cancel;
            btnSave.Enabled = save;
        }

        private void frm_SchoolYear_Load(object sender, EventArgs e)
        {
            Get_schoolyear("");
            txt_lst_enable_disable(true, true, false);
            btn_setup(true, false, false, false, false);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            lst_schoolyear.Items.Clear();
            Get_schoolyear(txtSearch.Text.Trim());
        }

        private void lst_schoolyear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lst_schoolyear.SelectedIndex > -1)
            {
                txt_Name.Text = lst_schoolyear.SelectedItem.ToString();
                btn_setup(false, true, true, true, false);
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            lst_schoolyear.SelectedIndex = -1;
            txt_Name.Focus();
            current_action = "add";
            txt_lst_enable_disable(false, false, true);
            btn_setup(false, false, false, true, true);
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();            
            txt_Name.Focus();
            current_action = "edit";
            txt_lst_enable_disable(false, false, true);
            btn_setup(false, false, false, true, true);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            current_action = "delete";
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this School year?", "Deleting School year", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string msg = SchoolYear.Delete(txt_Name.Text.Trim());
                if (msg.Contains("success"))
                {
                    MessageBox.Show(msg, "Deleted");
                    txt_Name.Clear();
                    txtSearch.Clear();
                    txtSearch.Focus();
                    lst_schoolyear.SelectedIndex = -1;
                    btn_setup(true, false, false, false, false);
                    txt_lst_enable_disable(true, true, false);
                    Get_schoolyear("");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            current_action = "cancel";
            txt_Name.Clear();
            txtSearch.Clear();
            txtSearch.Focus();
            lst_schoolyear.SelectedIndex = -1;
            btn_setup(true, false, false, false,false);
            txt_lst_enable_disable(true, true, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string msg = "";
            if(txt_Name.Text.Trim()==""||txt_Name.Text.Trim()==" ")
            {
                msg = "Invalid name";
            }
            else
            {
                if (current_action == "add")
                {
                    msg = SchoolYear.Add(txt_Name.Text.Trim());
                }
                else if (current_action == "edit")
                {
                    msg = SchoolYear.Edit(lst_schoolyear.SelectedItem.ToString(), txt_Name.Text);
                }
            }

            MessageBox.Show(msg, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (msg.ToLower().Contains("success"))
            {
                current_action = "cancel";
                txt_Name.Clear();
                txtSearch.Clear();
                txtSearch.Focus();
                lst_schoolyear.SelectedIndex = -1;
                btn_setup(true, false, false, false, false);
                txt_lst_enable_disable(true, true, false);
                Get_schoolyear("");
            }
        }
    }
}
