using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Constructor_Body
{
    public class ManagerBefore { public string Name; public int Grade;
        public ManagerBefore(string n, int g) { Name = n; Grade = g; Console.WriteLine("  Created Manager: "+n); } }
    public class EngineerBefore { public string Name; public int Grade;
        public EngineerBefore(string n, int g) { Name = n; Grade = g; Console.WriteLine("  Created Engineer: "+n); } }
    public class PullUpConstructorBody_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Pull Up Constructor Body - duplicated constructor code");
            new ManagerBefore("Alice", 3); new EngineerBefore("Bob", 2);
        }
    }
}
