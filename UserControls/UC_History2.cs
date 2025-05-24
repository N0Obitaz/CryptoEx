using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using WebSocketStreamingWithUI.Data;
using newUser = WebSocketStreamingWithUI.Data.User;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_History2 : UserControl
    {
        Connection connection = new Connection();
        newUser user = new newUser();
        public UC_History2()
        {
            InitializeComponent();
            FetchHistoryData();
        }



        private void FetchHistoryData()
        {


            try
            {
                using (MySqlConnection connect = new MySqlConnection(connection.GetConnectionString()))

                {
                    connect.Open();

                    string query = "SELECT * FROM history where username = @username ORDER BY date DESC";
                    using (MySqlCommand cmd = new MySqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", user.GetUser());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {

                            if (!reader.HasRows)
                            {
                                return;
                            }
                            int count = 0;

                            int j = 20;

                            List<HistoryItem> items = new List<HistoryItem>();

                            while (reader.Read())
                            {


                                items.Add(new HistoryItem
                                {
                                    Action = reader["action"].ToString(),
                                    Amount = float.Parse(reader["amount"].ToString()),
                                    DateTime = DateTime.Parse(reader["date"].ToString()),
                                    Currency = reader["currency"].ToString()
                                });


                            }
                            var groupedByDate = items
                            .GroupBy(x => x.DateTime.Date)
                            .OrderByDescending(g => g.Key);

                            int yOffset = 10;

                            foreach (var group in groupedByDate)
                            {
                                Guna2Panel groupingPanel = new Guna2Panel
                                {
                                    Size = new Size(850, 0),
                                    Location = new Point(10, yOffset),
                                    FillColor = Color.Transparent,
                                    BorderColor = Color.LightGray,
                                    AutoSize = true,
                                    AutoSizeMode = AutoSizeMode.GrowAndShrink
                                };

                                Label groupDateLabel = new Label
                                {
                                    Text = group.Key.ToString("MMMM dd, yyyy"),
                                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                                    ForeColor = Color.White,
                                    AutoSize = true,
                                    Location = new Point(20, 5)
                                };
                                groupingPanel.Controls.Add(groupDateLabel);

                                int innerYOffset = groupDateLabel.Bottom + 10;

                                foreach (var item in group)
                                {
                                    Guna2GradientPanel historyBox = new Guna2GradientPanel
                                    {
                                        Size = new Size(800, 63),
                                        Location = new Point(20, innerYOffset),
                                        FillColor = Color.FromArgb(192, 255, 255),
                                        FillColor2 = Color.FromArgb(0, 192, 192),
                                        BorderRadius = 20
                                    };

                                    string amount = (item.Action == "BUY" || item.Action == "DEPOSIT"||item.Action == "SWAP")
                                        ? "+ " + item.Amount.ToString("N2")
                                        : "- " + item.Amount.ToString("N2");

                                    historyBox.Controls.Add(new Label
                                    {
                                        Text = item.Action,
                                        Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                                        Location = new Point(23, 11),
                                        AutoSize = true
                                    });

                                    historyBox.Controls.Add(new Label
                                    {
                                        Text = amount,
                                        Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                                        Location = new Point(580, 10),
                                        ForeColor = (item.Action == "BUY" || item.Action == "DEPOSIT"||item.Action == "SWAP")
                                            ? Color.Green : Color.Red,
                                        AutoSize = true
                                    });

                                    historyBox.Controls.Add(new Label
                                    {
                                        Text = item.Currency,
                                        Font = new Font("Century Gothic", 10.2F),
                                        Location = new Point(41, 37),
                                        AutoSize = true
                                    });

                                    historyBox.Controls.Add(new Label
                                    {
                                        Text = item.DateTime.ToString("HH:mm:ss"),
                                        Font = new Font("Century Gothic", 9F),
                                        Location = new Point(700, 40),
                                        AutoSize = true
                                    });

                                    groupingPanel.Controls.Add(historyBox);
                                    innerYOffset += historyBox.Height + 10;
                                }

                                historyInsidePanel.Controls.Add(groupingPanel);
                                yOffset += groupingPanel.Height + 20;
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

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void historyLabel_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }


    public class HistoryItem
    {
        public string Action { get; set; }
        public float Amount { get; set; }
        public DateTime DateTime { get; set; }
        public string Currency { get; set; }
    }

}
