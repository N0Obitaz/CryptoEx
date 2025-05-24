using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WebSocketStreamingWithUI
{
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prog.Value < 100)
            {
                prog.Value += 1;
                percent.Text = prog.Value.ToString() + "%";

            }

            else
            {
                timer1.Stop();
                this.Hide();
                homepage home = new homepage();
                home.Show();
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {

            timer1.Start();


        }

        private void prog_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
