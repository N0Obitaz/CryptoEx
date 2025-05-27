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

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Transactions : UserControl
    {
        Connection connect = new Connection();

        public UC_Transactions()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void UC_Transactions_Load(object sender, EventArgs e)
        {
            exchangesCount.Text = CountEachTransaction("SWAP").ToString();
            countBuy.Text = CountEachTransaction("BUY").ToString();
            countSell.Text = CountEachTransaction("SELL").ToString();
            countWithdraw.Text = CountEachTransaction("WITHDRAW").ToString();
            countDeposit.Text = CountEachTransaction("DEPOSIT").ToString();

        }

        private int CountEachTransaction(string action)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connect.GetConnectionString()))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM history WHERE action = @action";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@action", action);
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
    }
}
