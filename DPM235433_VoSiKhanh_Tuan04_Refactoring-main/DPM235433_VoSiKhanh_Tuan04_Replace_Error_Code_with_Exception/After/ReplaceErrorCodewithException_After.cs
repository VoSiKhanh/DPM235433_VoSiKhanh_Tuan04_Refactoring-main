using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Error_Code_with_Exception
{
    public class ReplaceErrorCodewithException_After
    {
        public void Withdraw(double balance, double amount)
        {
            if (amount > balance) throw new InvalidOperationException("Insufficient funds");
            Console.WriteLine("  Withdrew: $" + amount);
        }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Error Code with Exception");
            try { Withdraw(100, 150); }
            catch (InvalidOperationException ex) { Console.WriteLine("  Exception: " + ex.Message); }
        }
    }
}
