using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Push Down Field ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new PushDownField_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new PushDownField_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new PushDownField_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
