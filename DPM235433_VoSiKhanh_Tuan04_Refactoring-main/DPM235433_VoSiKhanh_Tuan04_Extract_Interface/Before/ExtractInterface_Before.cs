using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Interface
{
    public class TimeSheet { private Employee _emp; public TimeSheet(Employee e){_emp=e;} 
        public double GetCharge(int days) => _emp.GetRate() * days; }
    public class Employee  { public double GetRate() => 50.0; public bool HasSpecialSkill() => true; }
    public class ExtractInterface_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Extract Interface - TimeSheet depends directly on Employee");
            var ts = new TimeSheet(new Employee());
            Console.WriteLine("  Charge for 5 days: $" + ts.GetCharge(5));
        }
    }
}
