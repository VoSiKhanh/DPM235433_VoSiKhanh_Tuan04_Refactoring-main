using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Error_Code_with_Exception
{
    public class ReplaceErrorCodewithException_Before
    {
        public int Withdraw(double balance, double amount)
        {
            if (amount > balance) return -1; // error code
            Console.WriteLine("  Withdrew: $" + amount);
            return 0; // success code
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Error Code with Exception");
            int result = Withdraw(100, 150);
            if (result == -1) Console.WriteLine("  Error: insufficient funds");
        }
    }
}
