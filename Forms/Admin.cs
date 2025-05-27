using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebSocketStreamingWithUI
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        public void Showform(UserControl uc)
        {

            string panel = Adminpanel.Name;
            Adminpanel.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Adminpanel.Controls.Add(uc);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            Showform(new AdminDashboard());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Showform(new AdminDashboard());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Showform(new UC_Users());
        }

        private void Adminpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
