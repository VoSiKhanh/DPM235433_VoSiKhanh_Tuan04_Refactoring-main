using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Field
{
    public abstract class EmployeeBase2 { public string Name; public EmployeeBase2(string n){Name=n;} }
    public class Engineer3 : EmployeeBase2 { public Engineer3(string n):base(n){} } // no Department
    public class Manager3  : EmployeeBase2 { public string Department; // pushed down here
        public Manager3(string n, string dept):base(n){Department=dept;} }
    public class PushDownField_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Push Down Field - Department only in Manager class");
            var mgr = new Manager3("Alice", "HR");
            Console.WriteLine("  Manager: " + mgr.Name + " | Dept: " + mgr.Department);
        }
    }
}
