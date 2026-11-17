using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Conditional_Expression
{
    public class ConsolidateConditionalExpression_After
    {
        private bool IsNotEligible(int seniority, int monthsDisabled, bool isPartTime)
            => seniority < 2 || monthsDisabled > 12 || isPartTime;

        public double GetDisabilityAmount(int seniority, int monthsDisabled, bool isPartTime)
        {
            if (IsNotEligible(seniority, monthsDisabled, isPartTime)) return 0;
            return 500.0;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Consolidate Conditional Expression");
            Console.WriteLine("  Disability amount: " + GetDisabilityAmount(3, 6, false));
        }
    }
}
