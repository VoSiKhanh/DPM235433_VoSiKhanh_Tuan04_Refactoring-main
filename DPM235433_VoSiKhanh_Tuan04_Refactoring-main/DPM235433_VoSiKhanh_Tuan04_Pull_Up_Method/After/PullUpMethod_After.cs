using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Method
{
    public abstract class BankAccount { public double GetAnnualInterest(double bal) => bal * 0.05; } // moved up
    public class SavingsAccountNew  : BankAccount {}
    public class CheckingAccountNew : BankAccount {}
    public class PullUpMethod_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Pull Up Method - GetAnnualInterest in base BankAccount");
            BankAccount[] accounts = { new SavingsAccountNew(), new CheckingAccountNew() };
            foreach (var a in accounts)
                Console.WriteLine("  " + a.GetType().Name + " interest: $" + a.GetAnnualInterest(1000));
        }
    }
}
