using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Parameter
{
    public class RemoveParameter_After
    {
        public string GetGreeting(string name) => "Hello, " + name + "!"; // removed unused param
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Remove Parameter - clean signature");
            Console.WriteLine("  " + GetGreeting("Alice"));
        }
    }
}
