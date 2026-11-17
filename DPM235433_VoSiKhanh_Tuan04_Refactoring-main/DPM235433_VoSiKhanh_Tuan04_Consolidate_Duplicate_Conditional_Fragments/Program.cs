using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Duplicate_Conditional_Fragments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Consolidate Duplicate Conditional Fragments ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ConsolidateDuplicateConditionalFragments_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ConsolidateDuplicateConditionalFragments_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ConsolidateDuplicateConditionalFragments_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
