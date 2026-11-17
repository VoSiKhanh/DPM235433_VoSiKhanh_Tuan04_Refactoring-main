using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Exception_with_Test
{
    public class ReplaceExceptionwithTest_After
    {
        public double Divide(double a, double b)
        {
            if (b == 0) return 0; // test first, no exception needed
            return a / b;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Exception with Test");
            Console.WriteLine("  10/2 = " + Divide(10, 2));
            Console.WriteLine("  10/0 = " + Divide(10, 0));
        }
    }
}
