using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Form_Template_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Form Template Method ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new FormTemplateMethod_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new FormTemplateMethod_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new FormTemplateMethod_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
