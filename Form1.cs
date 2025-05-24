
using System.Text;

using System.Net.WebSockets;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System;
using WebSocketStreamingWithUI.UserControls;
using WebSocketStreamingWithUI.TestWebSocket;
using MySqlX.XDevAPI;
namespace WebSocketStreamingWithUI


{
    public partial class Form1 : Form
    {
        HttpClientPHP _client = new HttpClientPHP();
        public Form1()
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
            Wallet wc = new Wallet();
            AddUserControl(wc, Mainpanel1);
           
        }

        private void exchangeButton_Click(object sender, EventArgs e)
        {
            UC_Exchange uC_Exchange = new UC_Exchange();

            AddUserControl(uC_Exchange, Mainpanel1);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Setting set = new Setting();
            AddUserControl(set, Mainpanel1);
            //security sec = new security();
            //AddUserControl(sec, Mainpanel1);
            //PersonalInfo personalInfo = new PersonalInfo();
            //AddUserControl(personalInfo, Mainpanel1);
        }
    }
}
