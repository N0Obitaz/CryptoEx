using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using System.Security.Cryptography;

namespace WebSocketStreamingWithUI.Class
{
    
    public class Passwordhash
    {
        public static void TogglePasswordVisibility(Guna2TextBox passwordBox, Guna2PictureBox iconBox, ref bool isVisible)
        {
            isVisible = !isVisible;
            passwordBox.UseSystemPasswordChar = !isVisible;

            iconBox.Image = isVisible
                ? Properties.Resources.hidden
                : Properties.Resources.eye;
        }




        public static string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();

                foreach (byte b in bytes)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }
    }
}
