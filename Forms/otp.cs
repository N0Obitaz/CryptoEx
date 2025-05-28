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
                MessageBox.Show("Login Successful");

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

      

        private System.Windows.Forms.Timer timer1;
        private int timeLeft = 60;  

        public void SetupTimer()
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1000; 
            timer1.Tick += timer1_Tick;
            timeLeft = 60;  

           
            Timerlabel.Text = "01:00";

            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
               
                Timerlabel.Text = TimeSpan.FromSeconds(timeLeft).ToString(@"mm\:ss");
            }
            else
            {
                timer1.Stop();
                Timerlabel.Text = "Time's up!";
               
            }
        }

        private void guna2Button1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
