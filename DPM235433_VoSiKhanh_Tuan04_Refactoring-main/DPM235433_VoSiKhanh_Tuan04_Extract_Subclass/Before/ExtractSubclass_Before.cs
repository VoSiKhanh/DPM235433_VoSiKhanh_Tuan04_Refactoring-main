using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Subclass
{
    public class JobItem { public string Description; public bool IsLabor; public double UnitPrice;
        public JobItem(string d, double p, bool isLabor){Description=d;UnitPrice=p;IsLabor=isLabor;}
        public double GetTotalPrice(int qty) => IsLabor ? qty * 50 : qty * UnitPrice;
    }
    public class ExtractSubclass_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Extract Subclass - all in one class");
            var j1 = new JobItem("Bolt", 1.5, false);
            var j2 = new JobItem("Labor", 0, true);
            Console.WriteLine("  Bolt x3: $" + j1.GetTotalPrice(3));
            Console.WriteLine("  Labor x2: $" + j2.GetTotalPrice(2));
        }
    }
}
