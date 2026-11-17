using System;
namespace DPM235433_VoSiKhanh_Tuan04_Hide_Method
{
    public class HideMethod_Real
    {
        private bool ValidateEmail(string email) => email.Contains("@");
        private string HashPassword(string pwd) => "HASHED_" + pwd.Length;
        public bool Register(string email, string pwd)
        {
            if (!ValidateEmail(email)) { Console.WriteLine("  Invalid email"); return false; }
            string hash = HashPassword(pwd);
            Console.WriteLine("  Registered: " + email + " | Hash: " + hash);
            return true;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Hide Method - User registration");
            Register("user@example.com", "secret123");
        }
    }
}
