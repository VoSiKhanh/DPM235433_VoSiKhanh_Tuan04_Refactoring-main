using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Replace_Conditional_with_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Replace Conditional with Polymorphism ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ReplaceConditionalwithPolymorphism_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ReplaceConditionalwithPolymorphism_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ReplaceConditionalwithPolymorphism_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
