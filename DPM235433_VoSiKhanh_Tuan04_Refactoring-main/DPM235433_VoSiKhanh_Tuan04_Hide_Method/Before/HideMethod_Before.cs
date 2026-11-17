using System;
namespace DPM235433_VoSiKhanh_Tuan04_Hide_Method
{
    public class HideMethod_Before
    {
        public double ConvertToUSD(double amount) => amount * 23000; // exposed publicly but only used internally
        public string GetPriceLabel(double vnd) => "$" + ConvertToUSD(vnd);
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Hide Method - ConvertToUSD is public but only used internally");
            Console.WriteLine("  " + GetPriceLabel(1000));
        }
    }
}
