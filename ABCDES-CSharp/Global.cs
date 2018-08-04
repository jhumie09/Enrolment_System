using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;

namespace ABCDES_CSharp
{
    class Global
    {       
         public static string[] lines = File.ReadAllLines("db_conn.txt");
         public static string server_str = lines[0].ToString();
         public static string db_str = lines[1].ToString();
         public static string username_str = lines[2].ToString();
         public static string password_str = lines[3].ToString();
         public static string sslmode = lines[4].ToString();
         public static string MyConn = "Server=" + server_str + ";Database=" + db_str + ";user id=" + username_str + ";Password=" + password_str + ";SslMode="+sslmode;

        
        //login Account
        public static string AccountType = "";
        public static string AccountName = "";
        public static string AccountID = "";
        public static string AccountEmp_ID = "";
        public static string Account_Password = "";
        public static bool FromLogin = false;

        //Account form Action
        public static string AffectedAccount = "";
        public static bool AddAccount = false;
        public static bool EditAccount = false;
        public static bool DeleteAccount = false;
        public static bool ResetPasswordAccount = false;

    }
}
