using System;
namespace DPM235433_VoSiKhanh_Tuan04_Parameterize_Method
{
    public class ParameterizeMethod_Real
    {
        public void PrintReport(string title, string data)
            => Console.WriteLine("  [" + title + "] " + data);
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Parameterize Method - Report printer");
            PrintReport("Sales", "Total: $50,000");
            PrintReport("Inventory", "Items: 1200");
        }
    }
}
