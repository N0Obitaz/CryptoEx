using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace WebSocketStreamingWithUI.Data
{
    public class User

    {
        public string user = "hihi";
        private string username;
        private string password;
        private string email;
        private float balance;

        

        public float GetBalance()
        {
            return balance;
        }
        public void GetUserDetails()
        {
            Connection connection = new Connection();
            string connectionString = connection.GetConnectionString();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    
                    conn.Open();
                    string selectQuery = "SELECT username, email, balance from users WHERE username = @user";


                    using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        cmd.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                Console.WriteLine("No records found.");
                                return;
                            }

                            while (reader.Read())
                            {

                               

                                email = reader["email"].ToString();
                                balance = float.Parse(reader["balance"].ToString());
                               
                                
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }

            
        }




    }
}
