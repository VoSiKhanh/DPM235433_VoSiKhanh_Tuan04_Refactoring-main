using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Constructor_with_Factory_Method
{
    public class EmployeeNew { public string Type; public string Name; private EmployeeNew(){} 
        public static EmployeeNew CreateEngineer(string name) => new EmployeeNew{Type="Engineer",Name=name};
        public static EmployeeNew CreateManager(string name)  => new EmployeeNew{Type="Manager",Name=name};
    }
    public class ReplaceConstructorwithFactoryMethod_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Constructor with Factory Method");
            var e = EmployeeNew.CreateEngineer("Alice");
            Console.WriteLine("  " + e.Type + ": " + e.Name);
        }
    }
}
