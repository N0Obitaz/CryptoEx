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
            string server = "192.168.101.85";
            string database = "trydb";
            string uid = "joed";
            string password = "12345678";
            _connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
        }

        public string GetConnectionString() => _connectionString;

        //Public method to insert full user registration
        public bool InsertData(string fname, string lname, string username, string email, string password, string role)
        {
            string query = "INSERT INTO users (Firstname, Lastname,UserName ,Email, Password, balance, Role) VALUES (@fname, @lname,@username, @email, @password, @balance, @role)";
            var parameters = new MySqlParameter[]
            {
                new MySqlParameter("@fname", fname),
                new MySqlParameter("@lname", lname),
                new MySqlParameter("@email", email),
                new MySqlParameter("@username", username),
                new MySqlParameter("@password", password),
                new MySqlParameter("@balance", 1000),
                new MySqlParameter("@role", role)
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
        public bool ValidateLogin(string emailOrUsername, string password)
        {
            using (MySqlConnection con = new MySqlConnection(_connectionString))
            {
                con.Open();
                string query = emailOrUsername.Contains("@")
                    ? "SELECT * FROM users WHERE email = @input AND password = @password"
                    : "SELECT * FROM users WHERE username = @input AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@input", emailOrUsername);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }
        public string GetEmailByUsername(string username)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT Email FROM users WHERE Username = @Username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        object result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching email: " + ex.Message);
                return null;
            }
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
       public (string Fullname, decimal Balance, string Role) GetUserInfo(string emailOrUsername)
{
            string fullname = "";
            decimal balance;
            string role = "";
            string query = "SELECT CONCAT(Firstname, ' ', Lastname) AS Fullname, Balance, Role FROM users WHERE Email = @identifier OR Username = @identifier";

    using (MySqlConnection conn = new MySqlConnection(_connectionString))
    {
        conn.Open();
        using (MySqlCommand cmd = new MySqlCommand(query, conn))
        {
            cmd.Parameters.AddWithValue("@identifier", emailOrUsername);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    fullname = reader.GetString("Fullname");
                    balance = reader.GetDecimal("Balance");
                    role = reader.GetString("Role");
                    return (fullname, balance, role);
                }
            }
        }
    }

    return (null, 0, null);
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
        public string GetRoleByIdentifier(string identifier)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    string query = "SELECT Role FROM users WHERE Email = @Identifier OR Username = @Identifier";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Identifier", identifier);
                        object result = cmd.ExecuteScalar();
                        return result?.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching role: " + ex.Message);
                return null;
            }
        }

    }

}
