using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Delegation_with_Inheritance
{
    public class PersonBase { public string Name; public PersonBase(string n){Name=n;}
        public string GetName() => Name; }
    public class EmployeeDelegate // delegates ALL methods to Person
    {
        private PersonBase _person;
        public EmployeeDelegate(string name){ _person = new PersonBase(name); }
        public string GetName() => _person.GetName(); // simple delegation
        public double Salary => 50000;
    }
    public class ReplaceDelegationwithInheritance_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Delegation with Inheritance");
            var emp = new EmployeeDelegate("Alice");
            Console.WriteLine("  "+emp.GetName()+" salary: $"+emp.Salary);
        }
    }
}
