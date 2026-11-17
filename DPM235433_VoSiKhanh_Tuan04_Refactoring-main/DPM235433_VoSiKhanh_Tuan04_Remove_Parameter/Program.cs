using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Remove_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Remove Parameter ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new RemoveParameter_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new RemoveParameter_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new RemoveParameter_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
