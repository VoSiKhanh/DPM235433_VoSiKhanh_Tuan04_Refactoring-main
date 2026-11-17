using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Extract_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Extract Interface ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ExtractInterface_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ExtractInterface_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ExtractInterface_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
