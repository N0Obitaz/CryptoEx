
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
            customizingPanel.Size = new Size(1136, 733);
           
            customizingPanel.Controls.Add(userControl);
            userControl.BringToFront();
            customizingPanel.BringToFront();
        }

        
        private async void Form1_Load_1(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc, Mainpanel1);
           
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc, Mainpanel1);

        }
        private void marketRatePanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void historyButton_Click(object sender, EventArgs e)
        {
            //UC_History uC_History = new UC_History();
            //AddUserControl(uC_History, marketRatePanel);
            UC_History2 uC_History2 = new UC_History2();
            AddUserControl(uC_History2, Mainpanel1);
        }

        private void walletButton_Click(object sender, EventArgs e)
        {
            var uC_Wallet = new UC_Wallet();
            AddUserControl(uC_Wallet, Mainpanel1);
        }
     
        private void exchangeButton_Click(object sender, EventArgs e)
        {
            UC_Exchange uC_Exchange = new UC_Exchange();
          
            AddUserControl(uC_Exchange, Mainpanel1);
        }
    }
}
