
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


        private void AddUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            marketRatePanel.Controls.Clear();
            marketRatePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private async void Form1_Load_1(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc);
        }
        private void dashboardButton_Click(object sender, EventArgs e)
        {
            UC_Market uc = new UC_Market();
            AddUserControl(uc);

        }
    }
}
