using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Parameter_Object
{
    public class IntroduceParameterObject_Before
    {
        public double GetTotal(double price, int qty, double tax, double shipping)
            => price * qty + tax + shipping;
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Introduce Parameter Object - too many params");
            Console.WriteLine("  Total: $" + GetTotal(10.0, 3, 2.5, 5.0));
        }
    }
}
