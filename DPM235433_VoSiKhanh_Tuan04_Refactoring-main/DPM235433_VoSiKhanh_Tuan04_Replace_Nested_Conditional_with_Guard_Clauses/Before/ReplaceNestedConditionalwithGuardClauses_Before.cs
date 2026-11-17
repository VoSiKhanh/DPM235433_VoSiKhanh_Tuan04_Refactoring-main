using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Nested_Conditional_with_Guard_Clauses
{
    public class ReplaceNestedConditionalwithGuardClauses_Before
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            double result;
            if (!isDead) { if (!isSeparated) { if (isRetired) result = 3000; else result = 5000; } else result = 1000; } else result = 0;
            return result;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Nested Conditional with Guard Clauses");
            Console.WriteLine("  Pay: " + GetPayAmount(false, false, false));
        }
    }
}
