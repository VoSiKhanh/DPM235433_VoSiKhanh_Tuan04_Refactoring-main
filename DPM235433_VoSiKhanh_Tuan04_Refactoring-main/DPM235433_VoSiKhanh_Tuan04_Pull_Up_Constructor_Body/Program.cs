using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Constructor_Body
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Pull Up Constructor Body ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new PullUpConstructorBody_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new PullUpConstructorBody_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new PullUpConstructorBody_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
