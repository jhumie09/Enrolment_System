using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCDES_CSharp
{
    class GradeLevel
    {        
        public static string Add(string name)
        {
            try
            {
                string msg;
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                            {
                                conn.Open();
                                string query = "Insert into tbl_gradelevel(Name) values ('" + name + "')";
                                MySqlCommand command = new MySqlCommand(query, conn);
                                command.ExecuteReader();
                                conn.Close();
                                msg = name + " successfully added.";
                            }                       
                
                return msg;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }        

        public static string Edit(string old_name, string new_name)
        {
            try
            {
                string msg;
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Update tbl_gradelevel set Name='" + new_name + "' where Name='" + old_name + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteReader();
                }
                msg = old_name + " change to " + new_name + " successfully";
                return msg;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public static string Delete(string name)
        {
            try
            {
                string msg;
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Delete from tbl_department Where Name='" + name + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteReader();
                }
                msg = name + " successfully deleted";
                return msg;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
