using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selland
{
    internal class DB
    {
        private MySqlConnection connection = new MySqlConnection("server=localhost;database=selland;uid=root;pwd=;");

        public MySqlConnection GetConnection()
        {
            return connection;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }

        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
                connection.Close();
        }
    }
}
