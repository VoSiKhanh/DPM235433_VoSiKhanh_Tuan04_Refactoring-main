using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Nested_Conditional_with_Guard_Clauses
{
    public class ReplaceNestedConditionalwithGuardClauses_Real
    {
        public string ProcessOrder(string user, string product, int qty)
        {
            if (string.IsNullOrEmpty(user)) return "Error: No user";
            if (string.IsNullOrEmpty(product)) return "Error: No product";
            if (qty <= 0) return "Error: Invalid quantity";
            return $"Order OK: {user} buys {qty}x {product}";
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Guard Clauses - Order processing");
            Console.WriteLine("  " + ProcessOrder("Alice", "Book", 2));
            Console.WriteLine("  " + ProcessOrder("", "Book", 2));
        }
    }
}
