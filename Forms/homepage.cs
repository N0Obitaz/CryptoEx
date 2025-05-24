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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        public void Showthisform(UserControl uc)
        {
            string panel1 = logpanel1.Name;
            logpanel1.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            logpanel1.Controls.Add(uc);

        }

        private void homepage_Load(object sender, EventArgs e)
        {
            Showthisform(new LoginPage(this));

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logpanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
