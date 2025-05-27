using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using WebSocketStreamingWithUI.Class;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI
{
    public partial class UC_Users : UserControl
    {
        List<UsersList> userList = new List<UsersList>();
        Userconnection userConn = new Userconnection();
        Connection connect = new Connection();
        public UC_Users()
        {
            InitializeComponent();
            GetUsersList();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void UC_Users_Load(object sender, EventArgs e)
        {

        }

        private void suspendButton_CheckedChanged(object sender, EventArgs e)
        {

           if (sender is Guna2ToggleSwitch toggle)
            {
                if (toggle != null)
                {
                    string id = toggle.Tag.ToString();
                    var name = toggle.Name;
                    
                    
                    userConn.ChangeStatus(id, name, toggle);
                }
                this.Hide();
                this.Show();
            }
        }
        


        public void GetUsersList()
        {
           
            try
            {
                using (var conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string selectAllQuery = "SELECT * FROM users WHERE role = @role";

                    using (MySqlCommand cmd = new MySqlCommand(selectAllQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@role", "user");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (!reader.HasRows) return;

                           
                            while (reader.Read())
                            {
                                userList.Add(new UsersList
                                {
                                    ID = reader["id"].ToString(),
                                    FullName = $"{reader["firstname"].ToString()} {reader["lastname"].ToString()}",

                                    Username = reader["username"].ToString(),
                                    Balance = float.Parse(reader["balance"].ToString()),

                                    Status = reader["status"].ToString(),
                                    Toggle = new Guna2ToggleSwitch(),
                                    
                                });
                                
                            }
                            int innerYOffset = 0;
                            foreach (var item in userList)
                            {
                              
                                Guna2Panel holdingsBox = new Guna2Panel
                                {
                                    Size = new Size(1195, 78),
                                    Location = new Point(0, innerYOffset),
                                    FillColor = Color.FromArgb(60, 63, 64),
                                    
                                    BorderRadius = 20
                                };

                                string ID = item.ID;

                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.ID,
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(22, 21),
                                    ForeColor = Color.White,
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    AutoSize = true,
                                });
                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.FullName,
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(157, 21),
                                    ForeColor = Color.White,
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    AutoSize = true,
                                });

                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.Username,
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(425, 21),

                                    ForeColor = Color.White,
                                    AutoSize = true,
                                    TextAlign = ContentAlignment.MiddleRight

                                });
                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.Balance.ToString("N2"),
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(662, 21),

                                    ForeColor = Color.White,
                                    AutoSize = true,
                                    TextAlign = ContentAlignment.MiddleRight

                                });
                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.Status,
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(858, 21),

                                    ForeColor = item.Status == "SUSPENDED"? Color.Red : Color.Green,
                                    AutoSize = true,
                                    TextAlign = ContentAlignment.MiddleRight

                                });
                                var toggleBox = new Guna2ToggleSwitch
                                {
                                    Name = item.Status,
                                    Size = new Size(80, 33),
                                    Tag = item.ID.ToString(),
                                    
                                    Font = new Font("Times New Roman", 16F, FontStyle.Bold),
                                    Location = new Point(1080, 21),
                                    Checked = CheckStatus(item.ID, item.Status)
                                };
                                
                                toggleBox.CheckedChanged += suspendButton_CheckedChanged;

                                holdingsBox.Controls.Add(toggleBox);
                                usersPanel.Controls.Add(holdingsBox);
                                innerYOffset += holdingsBox.Height + 10;

                                
                                
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        public bool CheckStatus(string id, string status)
        {
            try
            {
                using (var conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT status FROM users WHERE id = @id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", id);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                string statusFromDb = reader["status"].ToString();
                                if (statusFromDb == "SUSPENDED") return true;
                                else return false;
                            }

                        }
                    }
                }
            }
            catch
            {

            }
            return false;
        }


    }
    public class UsersList
    {
        public string ID { get; set; }
        public string FullName { get; set; } 


        public string Username { get; set; }
        public float Balance { get; set; }
   
        public string Status { get; set; }
        public Guna2ToggleSwitch Toggle { get; set; }

    }
}
