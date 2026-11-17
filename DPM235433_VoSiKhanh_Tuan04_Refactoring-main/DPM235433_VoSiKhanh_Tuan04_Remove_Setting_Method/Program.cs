using System;
using System.Text;

namespace DPM235433_VoSiKhanh_Tuan04_Remove_Setting_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("=== Remove Setting Method ===");
            Console.WriteLine();
            Console.WriteLine("--- BEFORE ---");
            new RemoveSettingMethod_Before("InitialName").Demonstrate();
            Console.WriteLine();
            Console.WriteLine("--- AFTER ---");
            new RemoveSettingMethod_After("InitialName").Demonstrate();
            Console.WriteLine();
            Console.WriteLine("--- REAL WORLD ---");
            new RemoveSettingMethod_Real("ORD-2024-001").Demonstrate();
            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
