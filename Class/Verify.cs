using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSocketStreamingWithUI.Class
{
    internal class Verify
    {
        private static Dictionary<string, (string otp, DateTime expiry)> otpStorage = new Dictionary<string, (string, DateTime)>();
        public static string Generateotp;

        public static void SendOtp(string email)
        {
            Generateotp = Generate();
            otpStorage[email] = (Generateotp, DateTime.Now.AddMinutes(1));
            sendemail.SendingemailOtp(email, Generateotp);
        }

        public static string Generate()
        {
            Random random = new Random();
            return random.Next(10000, 99999).ToString();
        }

        //Verify OTP Entered
        public static bool VerifyOtp(string email, string userOTP)
        {
            if (otpStorage.ContainsKey(email))
            {
                var (otp, expiry) = otpStorage[email];
                if (DateTime.Now <= expiry && userOTP == otp)
                {
                    otpStorage.Remove(email); // Remove OTP after verification
                    return true;
                }
            }
            return false;
        }
    }
}

