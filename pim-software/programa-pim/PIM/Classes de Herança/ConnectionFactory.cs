using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PIM
{
    class ConnectionFactory
    {
        private String StrConnection;

        public ConnectionFactory()
        {
            StrConnection = @"server=localhost;database=PIM;userid=root;password=1234;SslMode=none;convert zero datetime=True;";
        }

        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(StrConnection);
            return conn;
        }
    }
}
