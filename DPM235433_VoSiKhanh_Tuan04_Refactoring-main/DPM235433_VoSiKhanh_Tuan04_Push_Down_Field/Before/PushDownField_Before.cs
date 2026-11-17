using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Field
{
    public abstract class EmployeeBase { public string Name; public string Department; // only Manager uses Department
        public EmployeeBase(string n){Name=n;} }
    public class Engineer2 : EmployeeBase { public Engineer2(string n):base(n){} }
    public class Manager2  : EmployeeBase { public Manager2(string n, string dept):base(n){Department=dept;} }
    public class PushDownField_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Push Down Field - Department in base but only Manager uses it");
            var eng = new Engineer2("Bob"); // Department is null/unused
            var mgr = new Manager2("Alice", "HR");
            Console.WriteLine("  Engineer dept: '" + eng.Department + "' | Manager dept: " + mgr.Department);
        }
    }
}
