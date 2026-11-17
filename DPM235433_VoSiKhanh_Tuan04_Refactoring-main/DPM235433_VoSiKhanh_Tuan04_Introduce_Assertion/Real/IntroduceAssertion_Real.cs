using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Assertion
{
    public class IntroduceAssertion_Real
    {
        public double Divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("Divisor cannot be zero");
            return a / b;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Introduce Assertion - Safe division");
            Console.WriteLine("  10 / 2 = " + Divide(10, 2));
            try { Divide(10, 0); } catch (Exception ex) { Console.WriteLine("  Error caught: " + ex.Message); }
        }
    }
}
