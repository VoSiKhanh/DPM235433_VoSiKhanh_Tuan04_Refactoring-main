using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Preserve_Whole_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Preserve Whole Object ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new PreserveWholeObject_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new PreserveWholeObject_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new PreserveWholeObject_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
