using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Method_Call
{
    public class ReplaceParameterwithMethodCall_After
    {
        private int GetBasePrice() => 100;
        private double GetDiscountLevel() => GetBasePrice() > 80 ? 0.2 : 0.1;
        public double GetFinalPrice() => GetBasePrice() * (1 - GetDiscountLevel()); // calls internally
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Parameter with Method Call");
            Console.WriteLine("  Final: $" + GetFinalPrice());
        }
    }
}
