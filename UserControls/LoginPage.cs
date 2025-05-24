using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.Class;
using static WebSocketStreamingWithUI.Class.Passwordhash;

namespace WebSocketStreamingWithUI
{
    public partial class LoginPage : UserControl
    {
        private homepage _home;


        bool isPasswordVisible = false;
        public LoginPage(homepage home)
        {
            InitializeComponent();
            _home = home;
            passtbox.UseSystemPasswordChar = true;
            pictoggle.Image = Properties.Resources.hidden;

            if (Properties.Settings.Default.remember)
            {
                emailtbox.Text = Properties.Settings.Default.email;
                passtbox.Text = Properties.Settings.Default.password;
                remcheckbox.Checked = true;
            }
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _home.Showthisform(new Registerpage(_home));
        }



        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            string email = emailtbox.Text;
            string pass = passtbox.Text;
            string hashedPassword = Passwordhash.HashPassword(pass);

            User user = new User(email, hashedPassword);

            if (!user.Isvalidforlogin())
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            AuthService auth = new AuthService();
            if (auth.Login(user))
            {

                if (remcheckbox.Checked)
                {
                    Properties.Settings.Default.email = email;
                    Properties.Settings.Default.password = pass; 
                    Properties.Settings.Default.remember = true;
                    
                }
                else
                {
                    Properties.Settings.Default.email = "";
                    Properties.Settings.Default.password = "";
                    Properties.Settings.Default.remember = false;
                    
                }
                Properties.Settings.Default.Save();

                MessageBox.Show("Login Successful");
                Verify.SendOtp(user.Email);
                otp otpform = new otp(user.Email);
                otpform.Show();
                _home.Hide();

            }
            else
            {
                MessageBox.Show("Login Failed");
            }





        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictoggle_Click(object sender, EventArgs e)
        {
           
            Passwordhash.TogglePasswordVisibility(passtbox, pictoggle, ref isPasswordVisible);
        }
    }
}
