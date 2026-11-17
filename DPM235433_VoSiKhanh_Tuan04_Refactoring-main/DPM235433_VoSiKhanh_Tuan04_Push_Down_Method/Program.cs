using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Push Down Method ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new PushDownMethod_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new PushDownMethod_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new PushDownMethod_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
