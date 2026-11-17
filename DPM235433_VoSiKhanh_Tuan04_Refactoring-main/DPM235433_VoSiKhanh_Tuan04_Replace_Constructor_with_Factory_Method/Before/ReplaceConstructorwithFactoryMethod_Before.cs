using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Constructor_with_Factory_Method
{
    public class Employee
    {
        public string Type; public string Name;
        public Employee(int type, string name) { Type = type == 1 ? "Engineer" : "Manager"; Name = name; }
    }
    public class ReplaceConstructorwithFactoryMethod_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Constructor with Factory Method");
            var e = new Employee(1, "Alice");
            Console.WriteLine("  " + e.Type + ": " + e.Name);
        }
    }
}
