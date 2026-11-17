using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Method
{
    public class SavingsAccount { public double GetAnnualInterest(double bal) => bal * 0.05; }
    public class CheckingAccount { public double GetAnnualInterest(double bal) => bal * 0.05; }
    public class PullUpMethod_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Pull Up Method - GetAnnualInterest duplicated");
            Console.WriteLine("  Savings: $" + new SavingsAccount().GetAnnualInterest(1000));
            Console.WriteLine("  Checking: $" + new CheckingAccount().GetAnnualInterest(1000));
        }
    }
}
