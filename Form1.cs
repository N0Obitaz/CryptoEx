
using System.Text;

using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI


{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load_1;

        }
        public void AddUserControl(UserControl userControl, Guna.UI2.WinForms.Guna2Panel customizingPanel)
        {
            userControl.Dock = DockStyle.Fill;
            customizingPanel.Controls.Clear();
            customizingPanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private async void Form1_Load_1(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc, marketRatePanel);
            UC_Wallet uc_Wallet = new UC_Wallet();
            AddUserControl(uc_Wallet, walletPanel);


        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc, marketRatePanel);

        }


        private void marketRatePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            UC_History uC_History = new UC_History();
            AddUserControl(uC_History, marketRatePanel);
        }

        private void walletButton_Click(object sender, EventArgs e)
        {
            UC_Buy uC_Buy = new UC_Buy();
            AddUserControl(uC_Buy, marketRatePanel);
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            UC_Exchange uC_Exchange = new UC_Exchange();
            AddUserControl(uC_Exchange, marketRatePanel);
        }
    }
}
