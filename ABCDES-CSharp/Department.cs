using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ABCDES_CSharp
{
    class Department
    {
        public  static string Add(string name)
        {
            try
            {
                string msg;
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "SELECT * from tbl_department where Name='" + name + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            msg="Department name is already exist";
                        }
                        else
                        {
                            using (MySqlConnection conn1 = new MySqlConnection(Global.MyConn))
                            {
                                conn1.Open();                               
                                string query1 = "Insert into tbl_department(Name) values ('" + name + "')";
                                MySqlCommand command1 = new MySqlCommand(query1, conn1);
                                command1.ExecuteReader();
                                conn1.Close();
                                msg=name + " successfully added.";
                            }
                        }
                    }
                    conn.Close();                    
                }
                return msg;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }            
        }

        public static string Edit(string old_name,string new_name)
        {
            try
            {
                string msg;
                using (MySqlConnection conn = new MySqlConnection(Global.MyConn))
                {
                    conn.Open();
                    string query = "Update tbl_department set Name='" + new_name + "' where Name='" + old_name + "'";
                    MySqlCommand command = new MySqlCommand(query, conn);
                    command.ExecuteReader();
                }
                msg = old_name + " change to " + new_name +" successfully";
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
