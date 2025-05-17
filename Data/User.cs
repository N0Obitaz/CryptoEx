using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
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
        public void UpdateUserBalance(string amount)
        {
            
            UpdateBalance(float.Parse(amount));
        }
        private void UpdateBalance(float amount)
        {
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string UpdateQuery = "UPDATE users SET balance = balance + @amount WHERE username = @username";

                    using (var cmd = new MySqlCommand(UpdateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@username", GetUser().ToString());

                       object result =  cmd.ExecuteNonQuery();
                        if (int.Parse(result.ToString()) > 0)
                        {
                            string action = "DEPOSIT";
                            string currency = "USDT";
                            InsertToHistory(GetUser(), action, amount, currency);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        public void InsertToHistory(string username, string action, float amount, string currency)
        {
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO history(username, action, amount, date, currency) VALUES (@username, @action, @amount, @date, @currency)";

                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@action", action);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@currency", currency);

                        object result = cmd.ExecuteNonQuery();
                        if (float.Parse(result.ToString()) > 0)
                        {
                            MessageBox.Show("Data Inserted Successfully");
                        }
                    }

                }
            } catch (Exception ex) 
            {

            }
        }



    }
    
}
