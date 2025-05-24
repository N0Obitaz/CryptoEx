using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WebSocketStreamingWithUI.Class
{
    //Encapsulation with Abstraction
    public class Connection
    {
        private readonly string _connectionString;

        //Constructor: initializes the connection string
        public Connection()
        {
            string server = "192.168.100.44";
            string database = "trydb";
            string uid = "joed";
            string password = "12345678";
            _connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
        }

        public string GetConnectionString() => _connectionString;

        //Public method to insert full user registration
        public bool InsertData(string fname, string lname, string email, string password)
        {
            string query = "INSERT INTO users (Firstname, Lastname, Email, Password, Amount) VALUES (@fname, @lname, @email, @password, @amount)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@fname", fname),
                new MySqlParameter("@lname", lname),
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", password),
                new MySqlParameter("@amount", 1000)
            };

            return ExecuteNonQuery(query, parameters);
        }

        //Optional: simple insert for email + pass only
        public bool Insert(string email, string password)
        {
            string query = "INSERT INTO users (Email, Password) VALUES (@email, @password)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", password)
            };

            return ExecuteNonQuery(query, parameters);
        }

        //Login Credentials Validation
        public bool ValidateLogin(string email, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE Email = @email AND Password = @password";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@email", email),
                new MySqlParameter("@password", password)
            };

            return ExecuteScalarCount(query, parameters) > 0;
        }

        //User exists Check
        public bool UserExists(string email)
        {
            string query = "SELECT COUNT(*) FROM users WHERE Email = @Email";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@Email", email)
            };

            return ExecuteScalarCount(query, parameters) > 0;
        }

        // Get User Info
        public (string Fullname, string Balance) GetUserInfo(string email)
        {
            string fullname = "";
            string balance = "";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT CONCAT(Firstname, ' ', Lastname) AS Fullname, Amount FROM users WHERE Email = @Email";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                fullname = reader["Fullname"].ToString();
                                balance = reader["Amount"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return (fullname, balance);
        }

        // 🔄 Private helper: Execute INSERT, UPDATE, DELETE
        private bool ExecuteNonQuery(string query, MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddRange(parameters);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
                return false;
            }
        }

        // 🔍 Private helper: Execute SELECT COUNT(*)
        private int ExecuteScalarCount(string query, MySqlParameter[] parameters)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddRange(parameters);
                        return Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB Error: " + ex.Message);
                return 0;
            }
        }
    }
}
