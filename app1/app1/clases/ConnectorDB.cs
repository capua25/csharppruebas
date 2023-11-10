using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1.clases
{
    internal class ConnectorDB
    {
        string server = "localhost";
        string database = "app1";
        string uid = "root";
        string password = "1234";
        private MySqlConnector.MySqlConnection connection;

        public bool connected = false;

        public bool Connect()
        {
            string connectionString = $"Data Source={this.server};Database={this.database};User Id={this.uid};Password={this.password}";
            connection = new MySqlConnector.MySqlConnection(connectionString);
            try
            {
                connection.Open();
                connected = true;
                return true;
            }
            catch (MySqlConnector.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }
                return false;
            }   
        }

        public List<string> GetUsers()
        {
            string query = "SELECT * FROM usuarios";
            MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection);
            MySqlConnector.MySqlDataReader dataReader = cmd.ExecuteReader();
            List<string> result = new List<string>();
            while (dataReader.Read())
            {
                result.Add(dataReader["id"] + " " + dataReader["username"] + " " + dataReader["email"]);
            }
            dataReader.Close();
            return result;
        }   

        public void AddUser(string username, string password, string email)
        {
            string query = $"INSERT INTO usuarios (username, password, email) VALUES ('{username}', '{password}', '{email}')";
            MySqlConnector.MySqlCommand cmd = new MySqlConnector.MySqlCommand(query, connection);
            cmd.ExecuteNonQuery();
        }

        public ConnectorDB()
        {

        }
    }
}
