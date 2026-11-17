using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Decompose_Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Decompose Conditional ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new DecomposeConditional_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new DecomposeConditional_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new DecomposeConditional_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

