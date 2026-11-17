using System;
namespace DPM235433_VoSiKhanh_Tuan04_Hide_Method
{
    public class HideMethod_After
    {
        private double ConvertToUSD(double amount) => amount * 23000; // now private
        public string GetPriceLabel(double vnd) => "$" + ConvertToUSD(vnd);
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Hide Method - ConvertToUSD is now private");
            Console.WriteLine("  " + GetPriceLabel(1000));
        }
    }
}
