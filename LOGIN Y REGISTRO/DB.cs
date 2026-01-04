using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIN_Y_REGISTRO
{
    class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=sql10.freemysqlhosting.net;user id=sql10594764;password = isd8CniEEM; database=sql10594764");

        public void OpenConnnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public MySqlConnection GetConnection()
        {
            return connection;
        }
    }
}
