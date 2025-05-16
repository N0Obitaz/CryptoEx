using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WebSocketStreamingWithUI.Data;
using newUser = WebSocketStreamingWithUI.Data.User;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_History2 : UserControl
    {
        public UC_History2()
        {
            InitializeComponent();
            FetchHistoryData();
        }

        private void FetchHistoryData()
        {

            Connection connection = new Connection();
            newUser user = new newUser();
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connection.GetConnectionString()))

                {
                    connect.Open();

                    string query = "SELECT * FROM history where username = @username";
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
                            int j = 101;
                            while (reader.Read())
                            {
                                Guna.UI2.WinForms.Guna2GradientPanel historyBoxes = new Guna.UI2.WinForms.Guna2GradientPanel();


                                historyBoxes.Name = "historyBox" + count;
                                actionLabel.Text = reader["action"].ToString();
                                string amount;
                                if (actionLabel.Text == "BUY" || actionLabel.Text == "DEPOSIT")
                                {

                                    amount = "+ " + float.Parse(reader["amount"].ToString()).ToString("N2");
                                }
                                else amount = "- " + float.Parse(reader["amount"].ToString()).ToString("N2");
                                amountLabel.Text = amount;
                                DateTime dateTime = DateTime.Parse(reader["date"].ToString());

                                dateLabelHistory.Text = dateTime.ToString("MM-dd");
                                timeLabel.Text = dateTime.ToString("HH:mm:ss");
                                subAction.Text = reader["currency"].ToString();


                                count++;

                                var timeLbl = new Label()
                                {
                                    BackColor = Color.Transparent,
                                    Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                    Location = new Point(439, 35),
                                    Name = "timeLabel",
                                    Size = new Size(34, 22),
                                    TabIndex = 49,
                                    Text = dateTime.ToString("HH:mm:ss")
                                };
                                var dateLbl = new Label()
                                {
                                    AutoSize = true,
                                    BackColor = Color.White,
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                                    Location = new Point(38, 107),

                                    Name = "dateLabelHistory",
                                    Size = new Size(56, 23),
                                    TabIndex = 45,
                                    Text = dateLabelHistory.Text
                                };

                                var amountLbl = new Label()
                                {
                                    AutoSize = true,
                                    BackColor = Color.Transparent,
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                                    Location = new Point(403, 8),
                                    Name = "amountLabel",
                                    Size = new Size(80, 25),
                                    TabIndex = 48,
                                    Text = amountLabel.Text
                                };
                                var actionLbl = new Label()
                                {
                                    BackColor = Color.Transparent,
                                    Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
                                    Location = new Point(23, 11),
                                    Name = "actionLabel",
                                    Size = new Size(67, 25),
                                    TabIndex = 47,
                                    Text = actionLabel.Text
                                };
                                var subAct = new Label()
                                {
                                    BackColor = Color.Transparent,
                                    Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0),
                                    Location = new Point(41, 37),
                                    Name = "subAction",
                                    Size = new Size(93, 23),
                                    TabIndex = 50,
                                    Text = subAction.Text
                                };
                                historyBoxes.BorderRadius = 20;
                                historyBoxes.Name = "historyBoxes" + count;
                                historyBoxes.Size = new Size(523, 63);
                                historyBoxes.Location = new Point(37, j + 81);
                                historyBoxes.FillColor = Color.FromArgb(192, 255, 255);
                                historyBoxes.FillColor2 = Color.FromArgb(0, 192, 192);
                                historyBoxes.TabIndex = 46;
                                historyBoxes.Controls.Add(timeLbl);
                                historyBoxes.Controls.Add(dateLbl);
                                historyBoxes.Controls.Add(amountLbl);
                                historyBoxes.Controls.Add(actionLbl);
                                historyBoxes.Controls.Add(subAct);

                                //historyPanel.Controls.Add(historyBoxes);
                                historyBigPanel.Controls.Add(historyBoxes);
                                count++;
                                j += 81;
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
    }
}
