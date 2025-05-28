using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketStreamingWithUI.Class;

namespace WebSocketStreamingWithUI
{
    public partial class security : UserControl
    {
        public security()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string oldPassword = old.Text.Trim();
            string newPassword = newpass.Text.Trim();
            string confirmPass = cnewpass.Text.Trim();

          
            if (string.IsNullOrEmpty(oldPassword) ||
                string.IsNullOrEmpty(newPassword) ||
                string.IsNullOrEmpty(confirmPass))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            
            if (newPassword.Length < 8)
            {
                MessageBox.Show("New password must be at least 8 characters long.");
                return;
            }

          
            if (newPassword != confirmPass)
            {
                MessageBox.Show("New password and confirmation do not match.");
                return;
            }

          
            Connection conn = new Connection();
            bool result = conn.UpdatePassword(Session.LoggedInUserEmailOrUsername, oldPassword, newPassword);

            if (result)
            {
                MessageBox.Show("Password updated successfully!");
                old.Clear();
                newpass.Clear();
                cnewpass.Clear();
            }
            else
            {
                MessageBox.Show("Old password is incorrect or update failed.");
            }
        }
    }
}
