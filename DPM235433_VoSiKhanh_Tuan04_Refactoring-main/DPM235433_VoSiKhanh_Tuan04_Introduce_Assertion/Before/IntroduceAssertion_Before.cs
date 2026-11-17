using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Assertion
{
    public class IntroduceAssertion_Before
    {
        public double GetExpenseLimit(double expenseLimit)
        {
            // Hidden assumption: expenseLimit > 0, but not enforced
            return expenseLimit * 0.9;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Introduce Assertion");
            Console.WriteLine("  Limit: " + GetExpenseLimit(1000));
        }
    }
}
