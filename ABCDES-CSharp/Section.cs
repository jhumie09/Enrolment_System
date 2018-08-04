using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCDES_CSharp
{
    class Section
    {
        public static string Add(string section,string yearlevel,string useraccount)
        {
            string returnVal = "";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Call CRUD_section('add',null,'"+section+"','"+yearlevel+"','"+useraccount+"')";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                returnVal= reader.GetString(0).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                returnVal = ex.Message;
            }

            return returnVal;
        }
        public static string Edit(string tbl_id,string section,string yearlevel,string useraccount)
        {
            string returnVal = "";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Call CRUD_section('edit','"+tbl_id+"','" + section + "','" + yearlevel + "','" + useraccount + "')";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                returnVal = reader.GetString(0).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                returnVal = ex.Message;
            }

            return returnVal;
        }
        public static string Delete(string tbl_id,string useraccount,string section_name)
        {
            string returnVal = "";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Call CRUD_section('delete','" + tbl_id + "','"+section_name+"',null,'" + useraccount + "')";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                returnVal = reader.GetString(0).ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                returnVal = ex.Message;
            }

            return returnVal;
        }
    }
}
