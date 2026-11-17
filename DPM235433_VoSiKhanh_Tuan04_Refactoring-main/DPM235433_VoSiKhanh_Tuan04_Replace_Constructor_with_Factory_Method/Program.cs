using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Replace_Constructor_with_Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Replace Constructor with Factory Method ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ReplaceConstructorwithFactoryMethod_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ReplaceConstructorwithFactoryMethod_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ReplaceConstructorwithFactoryMethod_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
