using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Field
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Pull Up Field ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new PullUpField_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new PullUpField_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new PullUpField_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
