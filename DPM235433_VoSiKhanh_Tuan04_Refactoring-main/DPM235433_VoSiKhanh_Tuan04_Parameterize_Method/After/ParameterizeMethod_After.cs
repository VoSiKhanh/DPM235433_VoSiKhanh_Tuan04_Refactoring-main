using System;
namespace DPM235433_VoSiKhanh_Tuan04_Parameterize_Method
{
    public class ParameterizeMethod_After
    {
        public void RaiseSalary(double salary, double percent)
            => Console.WriteLine("  Raise " + (percent*100) + "%: $" + salary * (1 + percent));
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Parameterize Method - single unified method");
            RaiseSalary(5000, 0.10); RaiseSalary(5000, 0.20);
        }
    }
}
