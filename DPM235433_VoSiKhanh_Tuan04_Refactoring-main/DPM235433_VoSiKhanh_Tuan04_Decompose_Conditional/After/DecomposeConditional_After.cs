using System;
namespace DPM235433_VoSiKhanh_Tuan04_Decompose_Conditional
{
    public class DecomposeConditional_After
    {
        private bool IsOffPeakHour(int hour) => hour < 8 || hour > 22;
        private double NightRate(double price) => price * 1.5;
        private double DayRate(double price) => price * 1.0;

        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Decompose Conditional");
            int hour = 10;
            double price = 100;
            // Decomposed into named methods — easy to read
            double result = IsOffPeakHour(hour) ? NightRate(price) : DayRate(price);
            Console.WriteLine("  Price at hour " + hour + ": " + result);
        }
    }
}

