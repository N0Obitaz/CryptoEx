using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using WebSocketSharp;
using WebSocketStreamingWithUI.TestWebSocket;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI.Data
{
    

    public class User
        
    {

        public bool alreadyInsertedHistory = false;
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
        public void UpdateUserBalance(string amount, string operation, string currency)
        {
            
            UpdateBalance(float.Parse(amount), operation, currency);
        }
        public float CheckHoldings(string currency)
        {
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string CheckQuery = "SELECT * from Holdings WHERE fk_username = @username AND currency = @currency";

                    using (var cmd = new MySqlCommand(CheckQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", GetUser());
                        cmd.Parameters.AddWithValue("@currency", currency);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    return float.Parse(reader["quantity"].ToString());
                                }
                            }
                        }

                            
                    }

                }
            }
            catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message);
            }
            return 0.00000f;
        }
        
        public void UpdateHoldings(string currency, float amount, string operation)
        {

            try
            {
                string sign = "";
                string word = "";
                
                if (!string.IsNullOrEmpty(operation) && operation.Length > 1)
                {
                    // Split the sign and word from operation
                    sign = operation.Substring(0, 1);
                     word = operation.Substring(1);
                }

                string signForCalculation = word == "SWAP" && sign == "+"? "+" :
                                        word == "SWAP" && sign == "-"? "-":
                                        sign == "+" && word == "BUY" || word == "SELL" ? "-" : 
                                        sign == "-" && word == "BUY" || word == "SELL" ? "+" : sign;
            
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string UpdateQuery = $"UPDATE Holdings SET quantity = quantity {signForCalculation} @amount WHERE fk_username = @username AND @currency = currency";

                    using (var cmd = new MySqlCommand(UpdateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@username", GetUser());
                        cmd.Parameters.AddWithValue("@currency", currency);

                        object result = cmd.ExecuteNonQuery();

                        if (int.Parse(result.ToString()) > 0)
                        {
                                if (!alreadyInsertedHistory)
                                {
                                    // Save to History
                                    InsertToHistory(GetUser(), word, amount, currency);

                                }

                            alreadyInsertedHistory = true;

                        }
                      

                    }
                    

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        
        public void InsertToHoldings(string currency, float amount, string operation)
        {
            
            string word = operation.Substring(1);
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string insertQuery = "INSERT INTO Holdings (fk_username, currency,quantity) VALUES (@username, @currency, @amount)";
                    using (var cmd = new MySqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", GetUser());
                        cmd.Parameters.AddWithValue("@currency", currency);
                        cmd.Parameters.AddWithValue("@amount", amount);
                        object result = cmd.ExecuteNonQuery();
                        MessageBox.Show("Currency Successfully Bought!");

                        if (!alreadyInsertedHistory)
                        {
                            InsertToHistory(GetUser(), word, amount, currency);
                            alreadyInsertedHistory = true;
                        }
                        
                       
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error ngani " + ex.Message);
            }
        }

        public void UpdateBalance(float amount, string operation, string currency)
        {
        
           

           
            try
            {
                string sign = "";
                string word = "";
                if (!string.IsNullOrEmpty(operation) && operation.Length > 1)
                {
                     sign = operation.Substring(0, 1);
                     word = operation.Substring(1);
                }
                


                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string UpdateQuery = $"UPDATE users SET balance = balance {sign} @amount WHERE username = @username";

                    using (var cmd = new MySqlCommand(UpdateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@amount", amount);
                        cmd.Parameters.AddWithValue("@username", GetUser().ToString());

                        object result =  cmd.ExecuteNonQuery();
                        if (int.Parse(result.ToString()) > 0)
                        {
                            if(!alreadyInsertedHistory)
                            {
                                InsertToHistory(GetUser(), word, amount, currency);
                                alreadyInsertedHistory = false;
                            }
                           
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       public bool CheckUserBalance(string amount)
        {
            float convertAmount = float.Parse(amount);
            float balanceFrom;
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT balance from users WHERE username = @username";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", GetUser());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows) return false;
                            
                            while (reader.Read())
                            {
                                balanceFrom = float.Parse(reader["balance"].ToString());

                                if (balanceFrom > convertAmount)
                                {
                                    return true;
                                }
                            }

                        }

                    }
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            return false;

        }


        public void InsertToHistory(string username, string action, float amount, string currency)
        {
            MessageBox.Show(action.ToString());
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
