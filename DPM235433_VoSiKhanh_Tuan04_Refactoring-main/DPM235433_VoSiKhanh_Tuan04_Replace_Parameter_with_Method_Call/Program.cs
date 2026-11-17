using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Method_Call
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Replace Parameter with Method Call ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ReplaceParameterwithMethodCall_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ReplaceParameterwithMethodCall_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ReplaceParameterwithMethodCall_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
