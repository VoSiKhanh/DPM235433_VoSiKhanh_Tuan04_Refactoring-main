using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Hide_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Hide Method ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new HideMethod_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new HideMethod_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new HideMethod_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
