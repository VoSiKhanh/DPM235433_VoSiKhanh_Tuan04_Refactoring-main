using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Delegation_with_Inheritance
{
    public class PersonBase2 { public string Name; public PersonBase2(string n){Name=n;}
        public string GetName() => Name; }
    public class EmployeeInherits : PersonBase2 // inherits directly — no need to delegate
    {
        public double Salary => 50000;
        public EmployeeInherits(string name):base(name){}
    }
    public class ReplaceDelegationwithInheritance_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Delegation with Inheritance");
            var emp = new EmployeeInherits("Alice");
            Console.WriteLine("  "+emp.GetName()+" salary: $"+emp.Salary);
        }
    }
}
