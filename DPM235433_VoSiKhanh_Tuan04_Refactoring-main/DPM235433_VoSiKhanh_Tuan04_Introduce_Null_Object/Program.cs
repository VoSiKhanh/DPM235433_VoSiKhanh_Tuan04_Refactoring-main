using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Null_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Introduce Null Object ===");
            Console.WriteLine();
            Console.WriteLine("--- BEFORE ---");
            new IntroduceNullObject_Before().Demonstrate();
            Console.WriteLine();
            Console.WriteLine("--- AFTER ---");
            new IntroduceNullObject_After().Demonstrate();
            Console.WriteLine();
            Console.WriteLine("--- REAL WORLD ---");
            new IntroduceNullObject_Real(new ConsoleLogger()).Demonstrate();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
