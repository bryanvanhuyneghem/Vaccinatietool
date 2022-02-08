using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Vaccinatietool.Helper
{
    public class Database
    {
        //Verbinding openen en doorgeven aan DA
        public static MySqlConnection MakeConnection()
        {
            //Opstellen connectiestring
            MySqlConnectionStringBuilder connStringBuilder = new MySqlConnectionStringBuilder();
            connStringBuilder.Server = "localhost";
            connStringBuilder.Port = 3307;
            connStringBuilder.UserID = "root";
            connStringBuilder.Password = "usbw";
            connStringBuilder.Database = "vaccinatietool";

            //Connection-object aanmaken voor de verbinding, geven we uiteindelijk door aan DA.
            MySqlConnection conn = new MySqlConnection(connStringBuilder.ToString());
            conn.Open();
            return conn;
        }

        //Verbinding sluiten
        public static void CloseConnection(MySqlConnection conn)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
