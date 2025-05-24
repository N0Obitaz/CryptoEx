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

        public bool Login(User user)
        {
            return conn.ValidateLogin(user.Email, user.Password);
        }

        public void SendOTP(string email)
        {
            
           Verify.SendOtp(email);
        }
        public bool Register(User user)
        {
            return conn.InsertData(user.Firstname, user.Lastname, user.Email, user.Password);
        }
    }
}
