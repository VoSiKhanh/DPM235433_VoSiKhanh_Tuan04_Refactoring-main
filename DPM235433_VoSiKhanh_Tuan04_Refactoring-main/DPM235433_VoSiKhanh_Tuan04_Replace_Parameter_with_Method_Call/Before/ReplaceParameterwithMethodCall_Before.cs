using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Method_Call
{
    public class ReplaceParameterwithMethodCall_Before
    {
        public int GetBasePrice() => 100;
        public double GetDiscountLevel(int price) => price > 80 ? 0.2 : 0.1;
        public double GetFinalPrice(int basePrice, double discount) => basePrice * (1 - discount);
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Parameter with Method Call");
            int basePrice = GetBasePrice();
            double discount = GetDiscountLevel(basePrice);
            Console.WriteLine("  Final: $" + GetFinalPrice(basePrice, discount));
        }
    }
}
