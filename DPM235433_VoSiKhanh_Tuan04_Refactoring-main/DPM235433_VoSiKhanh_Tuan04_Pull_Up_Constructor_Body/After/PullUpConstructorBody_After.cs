using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Constructor_Body
{
    public abstract class EmployeeAfter
    {
        public string Name; public int Grade;
        public EmployeeAfter(string n, int g) { Name = n; Grade = g; Console.WriteLine("  Created "+GetType().Name+": "+n); }
    }
    public class ManagerAfter  : EmployeeAfter { public ManagerAfter(string n, int g):base(n,g){} }
    public class EngineerAfter : EmployeeAfter { public EngineerAfter(string n, int g):base(n,g){} }
    public class PullUpConstructorBody_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Pull Up Constructor Body - constructor in base class");
            new ManagerAfter("Alice", 3); new EngineerAfter("Bob", 2);
        }
    }
}
