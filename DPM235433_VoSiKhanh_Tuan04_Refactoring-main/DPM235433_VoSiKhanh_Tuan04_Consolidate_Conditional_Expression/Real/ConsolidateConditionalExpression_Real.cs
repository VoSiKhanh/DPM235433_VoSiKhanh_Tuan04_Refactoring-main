using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Conditional_Expression
{
    public class ConsolidateConditionalExpression_Real
    {
        private bool IsInvalidOrder(string item, int qty, double price)
            => string.IsNullOrEmpty(item) || qty <= 0 || price <= 0;

        public string PlaceOrder(string item, int qty, double price)
        {
            if (IsInvalidOrder(item, qty, price)) return "Invalid order";
            return $"Order placed: {qty}x {item} @ ${price}";
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Consolidate Conditional Expression - Order validation");
            Console.WriteLine("  " + PlaceOrder("Apple", 3, 1.5));
            Console.WriteLine("  " + PlaceOrder("", 3, 1.5));
        }
    }
}
