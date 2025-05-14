using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI.Data
{
    public class User

    {
        private string user = "hihi";
        
        private string password;
        private string email;
        private float balance;

        Connection connection = new Connection();
        
      
        public string GetUser()
        {
            return user;
        }

        public float GetBalance()
        {
            return balance;
        }
        public void GetUserDetails()
        {
            
          
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connection.GetConnectionString()))
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
        public void GetHistory()
        {
            FetchHistoryData();

        }
        private void FetchHistoryData()
        {
            try
            {
                
                using (MySqlConnection connect = new MySqlConnection(connection.GetConnectionString()))

                {
                    connect.Open();
                    MessageBox.Show("Connected");
                    string query = "SELECT * FROM history where username = @username";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", user);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                           
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: ", ex.Message);
            }
        }



    }
}
