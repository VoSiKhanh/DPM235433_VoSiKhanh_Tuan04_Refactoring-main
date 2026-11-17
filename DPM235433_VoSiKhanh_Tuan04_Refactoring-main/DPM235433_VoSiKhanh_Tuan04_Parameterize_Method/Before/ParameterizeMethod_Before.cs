using System;
namespace DPM235433_VoSiKhanh_Tuan04_Parameterize_Method
{
    public class ParameterizeMethod_Before
    {
        public void Raise10Percent(double salary) => Console.WriteLine("  Raise 10%: $" + salary * 1.10);
        public void Raise20Percent(double salary) => Console.WriteLine("  Raise 20%: $" + salary * 1.20);
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Parameterize Method - duplicate methods");
            Raise10Percent(5000); Raise20Percent(5000);
        }
    }
}
