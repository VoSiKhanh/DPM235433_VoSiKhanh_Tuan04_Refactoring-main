using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Method
{
    public abstract class EmployeePDA { public string Name; public EmployeePDA(string n){Name=n;} }
    public class EngineerPDA : EmployeePDA { public EngineerPDA(string n):base(n){} } // no GetBonus
    public class ManagerPDA  : EmployeePDA { public ManagerPDA(string n):base(n){}
        public double GetBonus() => 5000; } // pushed down to Manager only
    public class PushDownMethod_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Push Down Method - GetBonus only in Manager");
            Console.WriteLine("  Manager bonus: $" + new ManagerPDA("Alice").GetBonus());
        }
    }
}
