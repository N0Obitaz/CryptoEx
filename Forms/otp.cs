using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using WebSocketStreamingWithUI.Class;

namespace WebSocketStreamingWithUI
{
    public partial class otp : Form
    {
        private string userEmail;


        public otp(string email)
        {
            InitializeComponent();
            userEmail = email;
            SetupTimer();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string otpcode = otptbox1.Text + otptbox2.Text + otptbox3.Text + otptbox4.Text + otptbox5.Text;


            if (Verify.VerifyOtp(userEmail, otpcode))
            {
                MessageBox.Show("OTP verified successfully!");

                Connection db = new Connection();
                var (fullname, balance, role) = db.GetUserInfo(userEmail);

                if (role == "admin")
                {
                    Admin admin = new Admin();
                    admin.Show();
                }
                else
                {

                    UserDashboard dashboard = new UserDashboard();
                    dashboard.Show();
                }

                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid OTP. Please try again.");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AuthService send = new AuthService();
            send.SendOTP(userEmail);

            if (timer1 != null)
            {
                timer1.Stop();
            }

            timeLeft = 60;
            Timerlabel.Text = "01:00";
            timer1.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void otp_Load(object sender, EventArgs e)
        {

        }

        private System.Windows.Forms.Timer timer1;
        private int timeLeft = 60;  // 60 seconds countdown

        public void SetupTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; // 1 second
            timer1.Tick += timer1_Tick;
            timeLeft = 60;  // reset to 60 seconds

            // Assuming you have a Label named labelTimer
            Timerlabel.Text = "01:00";

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                // Format mm:ss and display in label
                Timerlabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                Timerlabel.Text = "Time's up!";
                // Other code when timer ends
            }
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
