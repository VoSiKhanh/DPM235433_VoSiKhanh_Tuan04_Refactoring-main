using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Extract_Superclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Extract Superclass ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ExtractSuperclass_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ExtractSuperclass_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ExtractSuperclass_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
