using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Replace_Delegation_with_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Replace Delegation with Inheritance ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ReplaceDelegationwithInheritance_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ReplaceDelegationwithInheritance_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ReplaceDelegationwithInheritance_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
