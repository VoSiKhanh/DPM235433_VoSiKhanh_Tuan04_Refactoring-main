using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Add_Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Add Parameter ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new AddParameter_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new AddParameter_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new AddParameter_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
