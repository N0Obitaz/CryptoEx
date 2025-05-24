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
    }
}
