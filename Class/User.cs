using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace WebSocketStreamingWithUI.Class
{
    public class User
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }

        public User(string firstname, string lastname, string email, string password, string cpass)
        {
            Firstname = firstname;
            Lastname = lastname;
            Email = email;
            Password = password;
        }

        public bool Isvalidforlogin()
        {
            return !string.IsNullOrEmpty(Email) &&
                   !string.IsNullOrEmpty(Password) &&
                   Password.Length >= 8;
        }

        public bool Isvalidforregister(string confirmpassword, Guna2CheckBox ck)
        {
            return !string.IsNullOrEmpty(Firstname) &&
                   !string.IsNullOrEmpty(Lastname) &&
                   !string.IsNullOrEmpty(Email) &&
                   !string.IsNullOrEmpty(Password) &&
                   Password.Length >= 8 &&
                   ck.Checked &&
                   Password == Passwordhash.HashPassword(confirmpassword);

        }

    }
}
