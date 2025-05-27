using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace WebSocketStreamingWithUI
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Mouse_Hover(object sender, EventArgs e)
        {

            if (sender is Guna2PictureBox picture && picture.Parent is Guna2Panel panel)
            {

                panel.FillColor = Color.FromArgb(34, 35, 37);
            }

        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            if (sender is Guna2PictureBox picture && picture.Parent is Guna2Panel panel)
            {
                panel.FillColor = Color.Transparent;
            }

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsParagraph_Click(object sender, EventArgs e)
        {

        }
    }
}
