using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Parameter_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Introduce Parameter Object ===");
            Console.WriteLine();

            Console.WriteLine("--- BEFORE ---");
            var before = new IntroduceParameterObject_Before();
            before.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- AFTER ---");
            var after = new IntroduceParameterObject_After();
            after.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("--- REAL WORLD ---");
            var real = new IntroduceParameterObject_Real();
            real.Demonstrate();
            Console.WriteLine();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
