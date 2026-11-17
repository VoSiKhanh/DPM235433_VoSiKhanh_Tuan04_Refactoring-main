using System;
namespace DPM235433_VoSiKhanh_Tuan04_Rename_Method
{
    public class RenameMethod_Real
    {
        public double CalculateMonthlyInterest(double principal, double annualRate)
            => principal * (annualRate / 12);
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Rename Method - Monthly interest calculator");
            Console.WriteLine("  Monthly interest: $" + CalculateMonthlyInterest(10000, 0.06));
        }
    }
}
