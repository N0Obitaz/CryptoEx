using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.UserControls;

namespace WebSocketStreamingWithUI
{
    public partial class Dashboard : Form
    {
        private string fullname;
        private string amount;
        public Dashboard(string Fullname, string Balance)
        {
            InitializeComponent();
            this.fullname = Fullname;
            this.amount = Balance;
        }
        
        public void Showform(UserControl uc)
        {
           
            string panel = Mainpanel.Name;
            Mainpanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Mainpanel.Controls.Add(uc);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Showform(new UC_Market());
            balancelabel.Text = amount;
        }

        private void dashbtn_Click(object sender, EventArgs e)
        {
            //Showform(new DashBoardUc());
            changelb.Text = "DashBoard";
        }

        private void Exchbtn_Click(object sender, EventArgs e)
        {
            //Showform(new Exchange());
            changelb.Text = "Exchange";
        }

        private void wallbtn_Click(object sender, EventArgs e)
        {
            //Showform(new Wallet());
            changelb.Text = "Wallet";
        }

        private void hisbtn_Click(object sender, EventArgs e)
        {
            //Showform(new History());
            changelb.Text = "History";
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //Showform(new Setting());
            changelb.Text = "Setting";
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            balancelabel.Text = amount;
            Fullnamelb.Text = fullname;
        }
    }
}
