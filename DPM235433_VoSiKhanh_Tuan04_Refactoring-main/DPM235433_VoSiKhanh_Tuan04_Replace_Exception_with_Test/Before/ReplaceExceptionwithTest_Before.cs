using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Exception_with_Test
{
    public class ReplaceExceptionwithTest_Before
    {
        public double Divide(double a, double b)
        {
            try { return a / b; }
            catch (DivideByZeroException) { return 0; } // exception for expected case
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Exception with Test");
            Console.WriteLine("  10/2 = " + Divide(10, 2));
            Console.WriteLine("  10/0 = " + Divide(10, 0));
        }
    }
}
