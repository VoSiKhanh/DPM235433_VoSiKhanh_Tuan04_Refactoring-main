using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Method
{
    public abstract class Account { public double Balance; public Account(double b){Balance=b;} }
    public class SavingsAcc : Account { public SavingsAcc(double b):base(b){}
        public void ApplyInterest() { Balance *= 1.05; Console.WriteLine("  Savings after interest: $"+Balance); } }
    public class CurrentAcc : Account { public CurrentAcc(double b):base(b){} } // no interest
    public class PushDownMethod_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Push Down Method - ApplyInterest only for SavingsAccount");
            new SavingsAcc(1000).ApplyInterest();
        }
    }
}
