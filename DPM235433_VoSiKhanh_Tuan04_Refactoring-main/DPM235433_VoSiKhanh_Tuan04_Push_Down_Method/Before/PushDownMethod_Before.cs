using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Method
{
    public abstract class EmployeePDB { public string Name; public EmployeePDB(string n){Name=n;}
        public double GetBonus() => 5000; // only relevant for Manager!
    }
    public class EngineerPDB : EmployeePDB { public EngineerPDB(string n):base(n){} }
    public class ManagerPDB  : EmployeePDB { public ManagerPDB(string n):base(n){} }
    public class PushDownMethod_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Push Down Method - GetBonus in base but only for Manager");
            Console.WriteLine("  Engineer bonus: $" + new EngineerPDB("Bob").GetBonus()); // irrelevant!
        }
    }
}
