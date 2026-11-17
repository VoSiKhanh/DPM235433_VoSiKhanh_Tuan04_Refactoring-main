using System;
namespace DPM235433_VoSiKhanh_Tuan04_Add_Parameter
{
    public class AddParameter_Real
    {
        public double CalculateDiscount(double price, string memberType)
        {
            if (memberType == "Gold") return price * 0.2;
            if (memberType == "Silver") return price * 0.1;
            return price * 0.05;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Add Parameter - Discount calculation");
            Console.WriteLine("  Gold discount on $200: $" + CalculateDiscount(200, "Gold"));
        }
    }
}
