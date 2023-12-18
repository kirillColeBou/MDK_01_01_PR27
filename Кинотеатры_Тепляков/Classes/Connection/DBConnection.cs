using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Кинотеатры_Тепляков.Classes.Connection
{
    public class DBConnection
    {
        static readonly string connection = "server=localhost;database=Cinemas;uid=root;";
        public static MySqlConnection OpenConnection()
        {
            MySqlConnection Connection = new MySqlConnection(connection);
            Connection.Open();

            return Connection;
        }

        public static MySqlDataReader Query(string Sql, MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand(Sql, connection);
            return command.ExecuteReader();
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            connection.Close();
            MySqlConnection.ClearPool(connection);
        }
    }
}
