using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    class DataBase
    {
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=coursework;Uid=root;Pwd=''");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }
        public MySqlConnection connectionStatus()
        {
            return connection;
        }
    }
}
