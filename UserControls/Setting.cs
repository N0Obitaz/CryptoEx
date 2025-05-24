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
    public partial class Setting : UserControl
    {
        public Setting()
        {
            InitializeComponent();
        }

        public void Showthisform(UserControl uc)
        {

            string panel = Mainpanel2.Name;
            Mainpanel2.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            Mainpanel2.Controls.Add(uc);
        }
        private void Setting_Load(object sender, EventArgs e)
        {
            Showthisform(new PersonalInfo());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Showthisform(new PersonalInfo());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Showthisform(new security());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Showthisform(new About());
        }
    }
}
