using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Interface
{
    public interface IBillable { double GetRate(); bool HasSpecialSkill(); }
    public class EmployeeNew2 : IBillable { public double GetRate() => 50.0; public bool HasSpecialSkill() => true; }
    public class Contractor   : IBillable { public double GetRate() => 80.0; public bool HasSpecialSkill() => false; }
    public class TimeSheet2   { private IBillable _worker; public TimeSheet2(IBillable w){_worker=w;}
        public double GetCharge(int days) => _worker.GetRate() * days; }
    public class ExtractInterface_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Extract Interface - IBillable allows Employee or Contractor");
            Console.WriteLine("  Employee 5d: $" + new TimeSheet2(new EmployeeNew2()).GetCharge(5));
            Console.WriteLine("  Contractor 5d: $" + new TimeSheet2(new Contractor()).GetCharge(5));
        }
    }
}
