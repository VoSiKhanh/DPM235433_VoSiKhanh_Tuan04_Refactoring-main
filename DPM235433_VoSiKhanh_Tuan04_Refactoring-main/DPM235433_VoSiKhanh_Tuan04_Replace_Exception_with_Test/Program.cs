using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Replace_Exception_with_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Replace Exception with Test ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ReplaceExceptionwithTest_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ReplaceExceptionwithTest_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ReplaceExceptionwithTest_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
