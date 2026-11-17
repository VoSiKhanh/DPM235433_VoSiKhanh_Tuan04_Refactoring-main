using System;
namespace DPM235433_VoSiKhanh_Tuan04_Decompose_Conditional
{
    public class DecomposeConditional_Real
    {
        private bool IsSummer(DateTime date) => date.Month >= 6 && date.Month <= 8;
        private double SummerCharge(double usage) => usage * 0.12;
        private double WinterCharge(double usage) => usage * 0.08;

        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Decompose Conditional - Electricity billing");
            DateTime today = new DateTime(2024, 7, 15);
            double usage = 300;
            double bill = IsSummer(today) ? SummerCharge(usage) : WinterCharge(usage);
            Console.WriteLine("  Date: " + today.ToShortDateString() + " | Usage: " + usage + " kWh | Bill: $" + bill);
        }
    }
}

