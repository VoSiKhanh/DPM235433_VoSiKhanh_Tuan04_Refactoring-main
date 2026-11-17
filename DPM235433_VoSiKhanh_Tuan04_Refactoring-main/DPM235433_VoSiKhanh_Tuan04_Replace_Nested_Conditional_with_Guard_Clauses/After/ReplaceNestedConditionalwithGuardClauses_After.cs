using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Nested_Conditional_with_Guard_Clauses
{
    public class ReplaceNestedConditionalwithGuardClauses_After
    {
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return 0;           // guard clause
            if (isSeparated) return 1000;   // guard clause
            if (isRetired) return 3000;     // guard clause
            return 5000;                    // normal flow
        }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Nested Conditional with Guard Clauses");
            Console.WriteLine("  Pay (normal): " + GetPayAmount(false, false, false));
            Console.WriteLine("  Pay (retired): " + GetPayAmount(false, false, true));
        }
    }
}
