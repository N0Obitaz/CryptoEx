using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Linq.Expressions;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Mozilla;
using WebSocketSharp;
using WebSocketStreamingWithUI.TestWebSocket;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI.Class
{


    public class Userconnection

    {
        

        public bool alreadyInsertedHistory = false;

        private string currentUser = Session.LoggedInUserEmailOrUsername;
        

       
        public void SetUser(string username)
        {
            currentUser = username;
            //currentUser = "Stephen";
        }

        public void SetBalance(float balance)
        {
            this.balance = balance;
        }
        private float balance;

        private float epsilon = 0.0000001f;

        Connection connection = new Connection();
        public string GetUser()
        {
            return currentUser;
        }



       

        public Users GetUserDetailsByEmailOrUsername(string emailOrUsername)
        {
            Users user = null;

            using (var conn = new MySqlConnection(connection.GetConnectionString()))
            {
                conn.Open();

                string query = @"
                SELECT firstname, lastname, username, email, password, role, balance 
                FROM users 
                WHERE username = @input OR email = @input
                LIMIT 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@input", emailOrUsername);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user = new Users(
                                reader["firstname"].ToString(),
                                reader["lastname"].ToString(),
                                reader["username"].ToString(),
                                reader["email"].ToString(),
                                reader["password"].ToString(),
                                "",
                                Convert.ToDecimal(reader["balance"])
                            );
                        }
                    }
                }
            }

            return user;
        }
        
        public  Image  GetProfile(string username)
        {
            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT Profile FROM users WHERE Username = @username"; ;
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                byte[] imageBytes = (byte[])reader["Profile"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    return Image.FromStream(ms);
                                }
                            }
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error fetching profile image: " + ex.Message);
                return null;
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
            catch (Exception ex)
            {

                MessageBox.Show("Error7: " + ex.Message);
            }
            return 0.00000f;
        }

        public void DeleteHolding(string currency)
        {

            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string delQuery = "DELETE FROM holdings WHERE currency = @currency AND quantity < @epsilon";
                    using (var cmd = new MySqlCommand(delQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@currency", currency);
                        cmd.Parameters.AddWithValue("@epsilon", epsilon);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error1 " + ex.Message);
            }
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

                string signForCalculation = word == "SWAP" && sign == "+" ? "+" :
                                        word == "SWAP" && sign == "-" ? "-" :
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
                            if (CheckHoldings(currency) < epsilon)
                            {
                                DeleteHolding(currency);
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error2: " + ex.Message);
            }

        }

        public void InsertToHoldings(string currency, float amount, string operation)
        {

           
            try
            {
                string word = operation.Substring(1);
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
                //MessageBox.Show("error ngani " + ex.Message);
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

                        object result = cmd.ExecuteNonQuery();
                        if (int.Parse(result.ToString()) > 0)
                        {
                            if (!alreadyInsertedHistory)
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
                MessageBox.Show("Error3: " + ex.Message);
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
                MessageBox.Show("Error4: " + ex.Message);

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
            }
            catch (Exception ex)
            {

            }
        }

        public List<string> FetchFavorites()
        {
            List<string> collections = new List<string>();
            try
            {
                string currencies = "";
                using (var connect = new MySqlConnection(connection.GetConnectionString()))
                {
                    connect.Open();
                    string fetchQuery = "SELECT favorite_currency FROM favorites WHERE username = @username";

                    using (var cmd = new MySqlCommand(fetchQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", GetUser());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                currencies = reader["favorite_currency"].ToString();
                            }

                        }

                    }


                }
                string[] currencyList = currencies.Split(new[] { " - " }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string currency in currencyList)
                {
                    collections.Add(currency);
                }

                return collections;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error5: " + ex.Message);
            }
            return [];
        }
        

        public void AddToFavorite(string currency, UserControl userControl, Guna2Panel panel)
        {
            string username = GetUser(); 
            List<string> favorites = FetchFavorites();

            if (!favorites.Contains(currency))
            {
                favorites.Add(currency);
                string updatedFavorites = string.Join(" - ", favorites);

                try
                {
                    using (var conn = new MySqlConnection(connection.GetConnectionString()))
                    {
                        conn.Open();

                        // Check if user already has a favorites row
                        string checkQuery = "SELECT COUNT(*) FROM favorites WHERE username = @username";
                        using (var checkCmd = new MySqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@username", username);
                         
                            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (count == 0)
                            {
                                // Insert new row
                                string insertQuery = "INSERT INTO favorites (username, favorite_currency) VALUES (@username, @favorites)";
                                using (var insertCmd = new MySqlCommand(insertQuery, conn))
                                {
                                    insertCmd.Parameters.AddWithValue("@username", username);
                                    insertCmd.Parameters.AddWithValue("@favorites", updatedFavorites);
                                    insertCmd.ExecuteNonQuery();
                                    MessageBox.Show("Added to Favorites (new entry)!");
                                }
                            }
                            else
                            {
                                // Update existing row
                                string updateQuery = "UPDATE favorites SET favorite_currency = @favorites WHERE username = @username";
                                using (var updateCmd = new MySqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@favorites", updatedFavorites);
                                    updateCmd.Parameters.AddWithValue("@username", username);
                                    updateCmd.ExecuteNonQuery();
                                    MessageBox.Show("Added to Favorites!");
                                }
                            }

                            // Refresh UI
                            RefreshForm(userControl, panel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Currency already in your favorites.");
            }
        }
        public void RemoveToFavorite(string currency, UserControl userControl, Guna2Panel panel)
        {
            List<string> currencyList = FetchFavorites();
            currencyList.Remove(currency);

            string joined = string.Join(" - ", currencyList);

            try
            {
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string updateQuery = "UPDATE favorites SET favorite_currency = @joined WHERE username = @username";

                    using (var cmd = new MySqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@joined", joined);
                        cmd.Parameters.AddWithValue("@username", GetUser());


                        object res = cmd.ExecuteNonQuery();
                        if (float.Parse(res.ToString()) > 0)
                        {

                            RefreshForm(userControl, panel);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error6: " + ex.Message);

            }
        }
       
        public void RefreshForm(UserControl userControl, Guna2Panel panel)
        {
            UserDashboard form = new UserDashboard();
            form.AddUserControl(userControl, panel);
        }


        public float GetTotalAssets(string action)
        {
            try

            {
                float amount = 0;
                using (var conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    string selectQuery = "SELECT amount FROM history WHERE username = @username AND action = @action";

                    using (var cmd = new MySqlCommand(selectQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", GetUser());
                        cmd.Parameters.AddWithValue("@action", action);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows) return 0;

                            while (reader.Read())
                            {
                                amount += float.Parse(reader["amount"].ToString());
                            }

                            return amount;

                        }
                    }
                }
            }
            catch (Exception ex) { }
            return 0;
        }


        public void ChangeStatus(string ID, string status, Guna2ToggleSwitch toggle)
        {
           
            try
            {
                string updatedStatus = status == "ACTIVE" ? "SUSPENDED" : "ACTIVE";


                using (MySqlConnection conn = new MySqlConnection(connection.GetConnectionString()))
                {
                    conn.Open();
                    

                    using (MySqlCommand cmd = new MySqlCommand("UPDATE users SET status = @updatedStatus WHERE id = @ID", conn))
                    {
                        cmd.Parameters.AddWithValue("@updatedStatus", updatedStatus);
                        cmd.Parameters.AddWithValue("@ID", ID);
                        object result = cmd.ExecuteNonQuery();
                        int converted = int.Parse(result.ToString());
                        
                      
                        //toggle.Checked = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }

}


