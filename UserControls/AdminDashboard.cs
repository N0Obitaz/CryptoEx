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
using WebSocketStreamingWithUI.Class;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI
{
    public partial class AdminDashboard : UserControl
    {
        Connection connect = new Connection();
        public AdminDashboard()
        {
            InitializeComponent();
            this.Load += AdminDashboard_Load;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void Showform(UserControl uc)
        {

            string panel = AdminDashboardPanel.Name;
            AdminDashboardPanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            AdminDashboardPanel.Controls.Add(uc);
        }

        public int CountUsers()
        {
            try
            {
                using (var conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE Role = @role";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@role", "User");

                        object result = cmd.ExecuteScalar();
                        int total = Convert.ToInt32(result);

                        return total;
                    }

                }
            }
            catch
            {
                MessageBox.Show("ERROR here: ");
            }
            return 0;
        }

        public int CountTransactions()
        {

            try
            {
                using (var conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM history";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        int total = Convert.ToInt32(result);
                        return total;
                    }
                }
            }
            catch
            {

            }
            return 0;

        }
        public int CountStatuses(string status)
        {

            try
            {
                using (var conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM users WHERE status = @status";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@status", status);
                        object result = cmd.ExecuteScalar();
                        int total = Convert.ToInt32(result);
                        return total;
                    }
                }
            }
            catch
            {

            }
            return 0;

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            usersCount.Text = CountUsers().ToString();
            totalTransactions.Text = CountTransactions().ToString();
            suspendedCount.Text = CountStatuses("SUSPENDED").ToString();
            totalActive.Text = CountStatuses("ACTIVE").ToString();
        }

        private void guna2Panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewEachTransaction(object sender, EventArgs e)
        {
            Showform(new  UC_Transactions());
        }
    }
}
