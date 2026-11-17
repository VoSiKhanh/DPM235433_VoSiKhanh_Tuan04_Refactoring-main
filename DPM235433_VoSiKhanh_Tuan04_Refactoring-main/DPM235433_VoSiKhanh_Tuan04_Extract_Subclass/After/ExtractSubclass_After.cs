using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Subclass
{
    public class JobItemBase { public string Description; public double UnitPrice;
        public JobItemBase(string d, double p){Description=d;UnitPrice=p;}
        public virtual double GetTotalPrice(int qty) => qty * UnitPrice;
    }
    public class LaborItem : JobItemBase { private double _rate;
        public LaborItem(string d, double rate):base(d,0){_rate=rate;}
        public override double GetTotalPrice(int qty) => qty * _rate;
    }
    public class ExtractSubclass_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Extract Subclass - LaborItem is separate subclass");
            var bolt = new JobItemBase("Bolt", 1.5);
            var labor = new LaborItem("Labor", 50);
            Console.WriteLine("  Bolt x3: $" + bolt.GetTotalPrice(3));
            Console.WriteLine("  Labor x2: $" + labor.GetTotalPrice(2));
        }
    }
}
