using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Parameter
{
    public class RemoveParameter_Before
    {
        public string GetGreeting(string name, string unusedParam) // unusedParam not used
            => "Hello, " + name + "!";
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Remove Parameter - 'unusedParam' is never used");
            Console.WriteLine("  " + GetGreeting("Alice", "unused"));
        }
    }
}
