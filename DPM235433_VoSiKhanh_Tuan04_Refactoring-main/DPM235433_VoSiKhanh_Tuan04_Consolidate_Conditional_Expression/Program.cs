using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Conditional_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Consolidate Conditional Expression ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new ConsolidateConditionalExpression_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new ConsolidateConditionalExpression_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new ConsolidateConditionalExpression_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
