using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Assertion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Introduce Assertion ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new IntroduceAssertion_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new IntroduceAssertion_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new IntroduceAssertion_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
