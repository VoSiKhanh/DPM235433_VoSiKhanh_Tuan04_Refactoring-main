using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Superclass
{
    public class DeptA { public string Name; public double AnnualCost; public DeptA(string n, double c){Name=n;AnnualCost=c;} }
    public class DeptB { public string Name; public double AnnualCost; public DeptB(string n, double c){Name=n;AnnualCost=c;} }
    public class ExtractSuperclass_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Extract Superclass - Name/AnnualCost duplicated in both Depts");
            var a = new DeptA("Engineering", 500000);
            var b = new DeptB("Marketing", 300000);
            Console.WriteLine("  "+a.Name+": $"+a.AnnualCost+" | "+b.Name+": $"+b.AnnualCost);
        }
    }
}
