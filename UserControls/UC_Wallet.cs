﻿using System;
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
using WebSocketStreamingWithUI.UserControls;
using WebSocketStreamingWithUI.Class;
using WebSocketStreamingWithUI.TestWebSocket;

namespace WebSocketStreamingWithUI
{
    public partial class UC_Wallet : UserControl
    {
        Connection connection = new Connection();
        Userconnection user = new Userconnection();
        UC_Market uC_Market = new UC_Market();


        UserDashboard dash = new UserDashboard();
        public List<HoldingsItem> items = new List<HoldingsItem>();

        public UC_Wallet()
        {
            InitializeComponent();
            this.Load += UC_Wallet_Load;
            FetchHoldingData();
            GetAssetsValues();


        }
        private async Task CallAsync()
        {
            await GlobalServices.PriceClient.ConnectAsync();
            await GetHoldingValues();
        }
        private async void UC_Wallet_Load(object sender, EventArgs e)
        {


        }
        private string FetchDateOnlyData(string currency)
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connection.GetConnectionString()))
                {
                    connect.Open();
                    string fetchQuery = $"SELECT * FROM history WHERE currency = @currency ORDER BY DATE DESC LIMIT 1;";

                    using (var cmd = new MySqlCommand(fetchQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@currency", currency);
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    string date = reader["date"].ToString();
                                    return date;

                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERror: " + ex.Message);
            }
            return currency;
        }

        public async Task GetHoldingValues()
        {
            var prices = GlobalServices.PriceClient.CurrentPrices;
            try
            {
                Dictionary<string, float> calc = new Dictionary<string, float>();

                float calculate = 0;
                foreach (var item in items)
                {
                    foreach (var pr in prices)
                    {
                        string price = pr.Value.ToString("F2"); // formatted

                        if (pr.Key.ToString() == item.Currency)
                        {
                            calculate = item.Quantity * pr.Value;
                            if (!calc.ContainsKey(pr.Key.ToString()))
                            {
                                calc[item.Currency] = calculate;
                            }

                        }
;
                    }
                }
                float totalAssetValue = 0;
                foreach (var priceHeld in calc)
                {
                    totalAssetValue += priceHeld.Value;
                }
                assetHeldValue.Text = totalAssetValue.ToString("N2");
               


            }
            catch (Exception ex)
            {
                //removed catching message here

            }
            finally
            {

                GlobalServices.PriceClient.Dispose();
            }


        }
        public void GetAssetsValues()
        {
            float deposits = user.GetTotalAssets("DEPOSIT");
            amountDeposit.Text = deposits.ToString("N2");
            float withdrawn = user.GetTotalAssets("WITHDRAW");
            totalWithDrawn.Text = withdrawn.ToString("N2");
            balanceAvailable.Text = dash.balancelabel.Text;
            //MessageBox.Show(priceClient.currentPrices["BTC"].ToString());




        }

        public void SetBalance(Guna2HtmlLabel label)
        {
            balanceAvailable.Text = label.Text.ToString();
        }
        public void FetchHoldingData()
        {
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connection.GetConnectionString()))

                {
                    connect.Open();

                    string query = "SELECT * FROM holdings where fk_username = @username";
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



                            while (reader.Read())
                            {


                                items.Add(new HoldingsItem
                                {
                                    Currency = reader["currency"].ToString(),
                                    Quantity = float.Parse(reader["quantity"].ToString()),

                                    //Extract Date method in history
                                    //DateTime = DateTime.Parse(FetchDateOnlyData(reader["currency"].ToString()))

                                    DateTime = DateTime.Now
                                });
                            }
                            int yOffset = 5;

                            foreach (var item in items)
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




                                int innerYOffset = 0;


                                Guna2Panel holdingsBox = new Guna2Panel
                                {
                                    Size = new Size(650, 44),
                                    Location = new Point(13, innerYOffset),
                                    FillColor = Color.Transparent,


                                    BackColor = Color.Transparent
                                };

                                string amount = item.Quantity.ToString();



                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = amount,
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                                    Location = new Point(312, 7),
                                    ForeColor = Color.White,
                                    TextAlign = ContentAlignment.MiddleLeft,
                                    Size = new Size(121, 30)
                                });

                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.Currency,
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                                    ForeColor = Color.White,
                                    Location = new Point(63, 7),
                                    TextAlign = ContentAlignment.MiddleCenter,
                                    Size = new Size(60, 30)
                                });

                                holdingsBox.Controls.Add(new Label
                                {
                                    Text = item.DateTime.ToString("HH:mm:ss"),
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold),
                                    Location = new Point(500, 7),

                                    ForeColor = Color.White,
                                    Size = new Size(60, 30),
                                    TextAlign = ContentAlignment.MiddleRight

                                });

                                groupingPanel.Controls.Add(holdingsBox);
                                innerYOffset += holdingsBox.Height;


                                holdingsInsidePanel.Controls.Add(groupingPanel);
                                yOffset += groupingPanel.Height + 10;
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

        private void holdingsInsidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel29_Click(object sender, EventArgs e)
        {

        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            GetHoldingValues();
            await CallAsync();
        }

        private void balanceAvailable_Click(object sender, EventArgs e)
        {

        }
    }
    public class HoldingsItem
    {
        
        public string Currency { get; set; }
        public float Quantity { get; set; }
        public DateTime DateTime { get; set; }

    }
    public static class GlobalServices
    {
        public static WebSocketPriceClient PriceClient { get; } = new WebSocketPriceClient();
    }

}

   


