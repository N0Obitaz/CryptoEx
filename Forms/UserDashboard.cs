
using System.Text;

using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;
using WebSocketStreamingWithUI.UserControls;
using WebSocketStreamingWithUI.TestWebSocket;
using MySqlX.XDevAPI;
using WebSocketStreamingWithUI.Class;
using System.Xml;
using System.Globalization;
using System.Windows.Forms;
namespace WebSocketStreamingWithUI


{
    public partial class UserDashboard : Form
    {
        HttpClientPHP _client = new HttpClientPHP();
        Userconnection user = new Userconnection();
        public string availableBalance = "";
        CultureInfo philippineCulture = new CultureInfo("en-PH");

        
        private string fullname;
        private decimal amount;
        public UserDashboard()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;
            HttpClientPHP.GetPHPRate();

        }
        public void AddUserControl(UserControl userControl, Guna.UI2.WinForms.Guna2Panel customizingPanel)
        {
            userControl.Dock = DockStyle.Fill;
            customizingPanel.Controls.Clear();
            customizingPanel.Size = new Size(1136, 733);

            customizingPanel.Controls.Add(userControl);
            userControl.BringToFront();
            customizingPanel.BringToFront();
        }


        public async void Form1_Load_1(object sender, EventArgs e)
        {


            GetUser();
            UC_Market uc = new UC_Market();
            AddUserControl(uc, Mainpanel1);




        }

        public void GetUser()
        {
            string currentUser = Session.LoggedInUserEmailOrUsername;

            if (string.IsNullOrEmpty(currentUser))
            {
                MessageBox.Show("No user logged in.");
                return;
            }

            Users currentUserDetails = user.GetUserDetailsByEmailOrUsername(currentUser);

            if (currentUserDetails != null)
            {
                SetUserData(currentUserDetails);
            }
            else
            {
                MessageBox.Show("Failed to load user data.");
            }
        }
        public void SetUserData(Users user)
        {

            if (user == null) return;
            Connection con = new Connection();
            Userconnection users = new Userconnection();
            Image profileimage = users.GetProfile(user.Username);
            Namelabel.Text = user.Username;
            balancelabel.Text = user.Balance.ToString("C", philippineCulture);

            


            if (profilepic != null)
            {
                profilepic.Image = profileimage;
            }
            else
            {
                MessageBox.Show("No profile image found.");
            }

        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            GetUser();
            UC_Market uc = new UC_Market();
            AddUserControl(uc, Mainpanel1);
            Panelabel.Text = "User DashBoard";
            panelpic.Image = Properties.Resources.dashboard__2_;

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            //UC_History uC_History = new UC_History();
            //AddUserControl(uC_History, marketRatePanel);
            UC_History2 uC_History2 = new UC_History2();
            AddUserControl(uC_History2, Mainpanel1);
            Panelabel.Text = "History";
            panelpic.Image = Properties.Resources.report;
        }

        private void walletButton_Click(object sender, EventArgs e)
        {
            UC_Wallet wc = new UC_Wallet();
            if (availableBalance == "")
            {
                wc.SetBalance(balancelabel);
            }

            AddUserControl(wc, Mainpanel1);
            Panelabel.Text = "Wallet";
            panelpic.Image = Properties.Resources.wallet;

        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            UC_Exchange uC_Exchange = new UC_Exchange();
            AddUserControl(uC_Exchange, Mainpanel1);
            Panelabel.Text = "Exchange";
            panelpic.Image = Properties.Resources.money;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            AddUserControl(set, Mainpanel1);
            Panelabel.Text = "Setting";
            panelpic.Image = Properties.Resources.management;

        }


        private void withdraw_Click(object sender, EventArgs e)
        {
            var uC_Withdraw = new UC_Withdraw();
            AddUserControl(uC_Withdraw, Mainpanel1);

        }

        private void deposit_Click(object sender, EventArgs e)
        {

            UC_Deposit uC_Deposit = new UC_Deposit();
            AddUserControl(uC_Deposit, Mainpanel1);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetUser();
        }



        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Session.LoggedInUserEmailOrUsername = "";
            this.Hide();
            homepage home = new homepage();
            home.Show();
            Dispose();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {

        }

        private void balancelabel_Click(object sender, EventArgs e)
        {

        }
    }
}
