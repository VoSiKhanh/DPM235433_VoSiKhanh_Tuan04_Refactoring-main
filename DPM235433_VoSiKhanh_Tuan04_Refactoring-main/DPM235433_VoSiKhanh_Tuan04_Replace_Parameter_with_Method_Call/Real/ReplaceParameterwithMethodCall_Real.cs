using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Method_Call
{
    public class ReplaceParameterwithMethodCall_Real
    {
        private double GetTaxRate() => 0.08;
        public double GetTotalWithTax(double subtotal) => subtotal * (1 + GetTaxRate());
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Parameter with Method Call - Tax calculator");
            Console.WriteLine("  Total with tax: $" + GetTotalWithTax(100));
        }
    }
}
