using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Exception_with_Test
{
    public class ReplaceExceptionwithTest_Real
    {
        private Dictionary<int,string> _users = new Dictionary<int,string>{{1,"Alice"},{2,"Bob"}};
        public string GetUser(int id)
        {
            if (!_users.ContainsKey(id)) return "Unknown"; // test instead of exception
            return _users[id];
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Exception with Test - User lookup");
            Console.WriteLine("  User 1: " + GetUser(1));
            Console.WriteLine("  User 99: " + GetUser(99));
        }
    }
}
