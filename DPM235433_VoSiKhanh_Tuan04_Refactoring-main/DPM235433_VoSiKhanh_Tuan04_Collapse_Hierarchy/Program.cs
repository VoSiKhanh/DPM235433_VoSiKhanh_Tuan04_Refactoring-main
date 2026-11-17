using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Collapse_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Collapse Hierarchy ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new CollapseHierarchy_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new CollapseHierarchy_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new CollapseHierarchy_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
