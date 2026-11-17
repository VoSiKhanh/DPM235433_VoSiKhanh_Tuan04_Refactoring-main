using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Conditional_Expression
{
    public class ConsolidateConditionalExpression_Before
    {
        public double GetDisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (seniority < 2) return 0;
            if (monthsDisabled > 12) return 0;
            if (isPartTime) return 0;
            return 500.0;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Consolidate Conditional Expression");
            Console.WriteLine("  Disability amount: " + GetDisabilityAmount(3, 6, false));
        }
    }
}
