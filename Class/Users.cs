using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;

namespace WebSocketStreamingWithUI.Class
{
    public class Users
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        private decimal balance;  // private backing field

        public decimal Balance   // public property with encapsulation
        {
            get { return balance; }
            set
            {
                if (value >= 0)  // optional validation, no negative balances
                {
                    balance = value;
                }
            }
        }

        public string Role { get; set; }

        // Constructor for login usage (email or username)

        public Users(string emailorusername, string password)
        {
            if (emailorusername.Contains("@"))
            {
                Email = emailorusername;
                Username = string.Empty;
            }
            else
            {
                Username = emailorusername;
                Email = string.Empty;
            }
            Password = password;
        }

        // Full constructor including balance
        public Users(string firstname, string lastname, string username, string email, string password, string cpass, decimal balance = 0)
        {
            Firstname = firstname;
            Lastname = lastname;
            Username = username;
            Email = email;
            Password = password;
 
            Balance = balance;  // set through property
        }

        

        public bool Isvalidforlogin()
        {
            bool hasEmailOrUsername = !string.IsNullOrEmpty(Email) || !string.IsNullOrEmpty(Username);
            return hasEmailOrUsername &&
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
