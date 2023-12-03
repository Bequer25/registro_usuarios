using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registroUsuarios
{
    internal class conetionBD
    {
        public class DatabaseConnection
        {
            private static DatabaseConnection instance;
            private MySqlConnection connection;

            private DatabaseConnection()
            {
                // Configura la conexión a la base de datos
                string connectionString = "server=localhost;port=3306;uid=root;pwd='';database=tiendita;";
                connection = new MySqlConnection(connectionString);
            }

            public static DatabaseConnection Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new DatabaseConnection();
                    }
                    return instance;
                }
            }

            public MySqlConnection GetConnection()
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
                return connection;
            }
        }
    }
}
