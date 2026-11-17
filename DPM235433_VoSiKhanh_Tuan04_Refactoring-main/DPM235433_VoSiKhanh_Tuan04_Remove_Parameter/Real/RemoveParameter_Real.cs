using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Parameter
{
    public class RemoveParameter_Real
    {
        private string _currency = "USD";
        public string FormatPrice(double price) => $"${price:F2} {_currency}";
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Remove Parameter - Price formatter");
            Console.WriteLine("  " + FormatPrice(99.99));
        }
    }
}
