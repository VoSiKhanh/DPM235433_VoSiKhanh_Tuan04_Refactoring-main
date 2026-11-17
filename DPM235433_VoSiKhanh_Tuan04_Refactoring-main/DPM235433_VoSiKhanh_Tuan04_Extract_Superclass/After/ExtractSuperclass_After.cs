using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Superclass
{
    public abstract class Department { public string Name; public double AnnualCost;
        public Department(string n, double c){Name=n;AnnualCost=c;}
        public virtual void Print() => Console.WriteLine("  "+Name+": $"+AnnualCost); }
    public class EngineeringDept : Department { public EngineeringDept(string n, double c):base(n,c){} }
    public class MarketingDept   : Department { public MarketingDept(string n, double c):base(n,c){} }
    public class ExtractSuperclass_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Extract Superclass - Department is superclass");
            Department[] depts = { new EngineeringDept("Engineering",500000), new MarketingDept("Marketing",300000) };
            foreach (var d in depts) d.Print();
        }
    }
}
