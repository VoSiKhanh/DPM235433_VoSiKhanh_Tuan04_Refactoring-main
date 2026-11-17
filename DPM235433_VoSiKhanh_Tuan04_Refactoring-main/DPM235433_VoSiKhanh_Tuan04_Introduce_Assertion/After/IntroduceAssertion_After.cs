using System;
using System.Diagnostics;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Assertion
{
    public class IntroduceAssertion_After
    {
        public double GetExpenseLimit(double expenseLimit)
        {
            Debug.Assert(expenseLimit > 0, "Expense limit must be positive");
            if (expenseLimit <= 0) throw new ArgumentException("Expense limit must be positive");
            return expenseLimit * 0.9;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Introduce Assertion");
            Console.WriteLine("  Limit: " + GetExpenseLimit(1000));
        }
    }
}
