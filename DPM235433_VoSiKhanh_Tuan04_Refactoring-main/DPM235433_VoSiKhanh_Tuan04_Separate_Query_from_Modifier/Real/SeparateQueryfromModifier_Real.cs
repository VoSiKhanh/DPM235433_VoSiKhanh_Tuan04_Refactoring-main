using System;
namespace DPM235433_VoSiKhanh_Tuan04_Separate_Query_from_Modifier
{
    public class SeparateQueryfromModifier_Real
    {
        private double _balance = 1000;
        public double GetBalance() => _balance;           // query
        public void Deposit(double amount) { _balance += amount; } // modifier
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Separate Query from Modifier - Bank Account");
            Console.WriteLine("  Balance: $" + GetBalance());
            Deposit(500);
            Console.WriteLine("  After deposit: $" + GetBalance());
        }
    }
}
