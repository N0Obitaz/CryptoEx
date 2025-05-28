using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketStreamingWithUI.Class
{
    public class AuthService
    {
        private Connection conn = new Connection();

        public (bool Success, string Email, string Role) Login(Users user)
        {
            string identifier = !string.IsNullOrEmpty(user.Email) ? user.Email : user.Username;
            bool isValid = conn.ValidateLogin(identifier, user.Password);

            if (!isValid)
                return (false, null, null);

            string email = !string.IsNullOrEmpty(user.Email)
                ? user.Email
                : conn.GetEmailByUsername(user.Username);

            string role = conn.GetRoleByIdentifier(identifier);

            return (true, email, role);
        }

        public void SendOTP(string email)
        {
            
           Verify.SendOtp(email);
        }
        public bool Register(Users user)
        {
            return conn.InsertData(user.Username, user.Firstname,user.Lastname, user.Email, user.Password, user.Role);
        }
    }
}
