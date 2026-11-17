using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Separate_Query_from_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Separate Query from Modifier ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new SeparateQueryfromModifier_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new SeparateQueryfromModifier_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new SeparateQueryfromModifier_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
