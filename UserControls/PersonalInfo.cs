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
    public partial class PersonalInfo : UserControl
    {
        public PersonalInfo()
        {
            InitializeComponent();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select a Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Propic.Image = Image.FromFile(filePath);
                Propic.SizeMode = PictureBoxSizeMode.StretchImage;

                // Optional: save the path or file to database here
            }
        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string Fname = newfn.Text;
            string Lname = newln.Text;
            string Email = newemail.Text;
            int Age = tage.Text.Length;
            int cp = newcp.Text.Length;
            string add = newadd.Text;
            Image img = Propic.Image;


            if (Fname == "" || Lname == "" || Email == "" || Age < 1 || cp < 1 || add == "")
            {
                MessageBox.Show("Please fill in all fields.");
            }
            else
            {
                Connection conn = new Connection();
                conn.UpdateNameByUsername(Session.LoggedInUserEmailOrUsername, Fname, Lname, Email, add, Age, cp, img);
                // Here you can add code to save the updated information to the database or perform any other action.
                MessageBox.Show("Information updated successfully!");

            }
        }
    }
}
