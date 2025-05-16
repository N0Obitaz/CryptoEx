using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.Data;

namespace WebSocketStreamingWithUI.UserControls
{
    public partial class UC_Wallet : UserControl
    {
        public UC_Wallet()
        {
            InitializeComponent();
            GetUser();
        }

        private void GetUser()
        {
            User newUser = new User();
            newUser.GetUserDetails();

            balance.Text = newUser.GetBalance().ToString("N2");
        }

        private void balance_Click(object sender, EventArgs e)
        {

        }

        private void myBalanceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
