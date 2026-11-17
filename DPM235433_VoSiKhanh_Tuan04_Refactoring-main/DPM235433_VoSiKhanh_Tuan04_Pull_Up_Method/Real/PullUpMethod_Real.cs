using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Method
{
    public abstract class Report { public void PrintHeader() => Console.WriteLine("  === REPORT ==="); }
    public class SalesReport    : Report { public void Print() { PrintHeader(); Console.WriteLine("  Sales: $10,000"); } }
    public class InventoryReport: Report { public void Print() { PrintHeader(); Console.WriteLine("  Items: 500"); } }
    public class PullUpMethod_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Pull Up Method - PrintHeader in base Report class");
            new SalesReport().Print(); new InventoryReport().Print();
        }
    }
}
