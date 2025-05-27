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

namespace WebSocketStreamingWithUI
{

    public partial class Registerpage : UserControl
    {
        private homepage _home;
        bool ispassvisible = false;
        bool iscpassvisible = false;


        public Registerpage(homepage home)
        {
            InitializeComponent();
            _home = home;
            passtbox.UseSystemPasswordChar = true;
            cpasstbox.UseSystemPasswordChar = true;
            pictogglepass.Image = Properties.Resources.hidden;
            pictogglecpass.Image = Properties.Resources.hidden;
        }



        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _home.Showthisform(new LoginPage(_home));

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string fname = fntbox.Text;
            string lname = lntbox.Text;
            string email = emailtbox.Text;
            string username = usernametbox.Text;
            string pass = passtbox.Text;
            string cpass = cpasstbox.Text;
            string hashpass = Passwordhash.HashPassword(pass);
            string role = rolecb.SelectedItem.ToString();



            Users NewUser = new Users(fname, lname, username, email, hashpass, cpass, role);

            if (!NewUser.Isvalidforregister(cpass, checkbox))
            {
                MessageBox.Show("Please fill in all fields, ensure the password is at least 8 characters,passwords match and check the agreement box.");
                return;
            }

            AuthService auth = new AuthService();

            if (auth.Register(NewUser))
            {
                MessageBox.Show("Registration Successful");
                _home.Showthisform(new LoginPage(_home));
            }
            else
            {
                MessageBox.Show("Registration Failed");
            }
        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }



        private void pictogglepass_Click(object sender, EventArgs e)
        {
            Passwordhash.TogglePasswordVisibility(passtbox, pictogglepass, ref ispassvisible);
        }

        private void pictogglecpass_Click(object sender, EventArgs e)
        {
            Passwordhash.TogglePasswordVisibility(cpasstbox, pictogglecpass, ref iscpassvisible);
        }

        private void Registerpage_Load(object sender, EventArgs e)
        {

        }
    }
}
