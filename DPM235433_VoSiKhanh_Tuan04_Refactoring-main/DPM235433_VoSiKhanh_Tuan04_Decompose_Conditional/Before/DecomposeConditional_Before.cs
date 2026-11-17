using System;
namespace DPM235433_VoSiKhanh_Tuan04_Decompose_Conditional
{
    public class DecomposeConditional_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Decompose Conditional");
            int hour = 10;
            double price = 100;
            // Complex condition inline — hard to read
            if (hour < 8 || hour > 22)
                price = price * 1.5;
            else
                price = price * 1.0;
            Console.WriteLine("  Price at hour " + hour + ": " + price);
        }
    }
}

