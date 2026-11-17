using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Duplicate_Conditional_Fragments
{
    public class ConsolidateDuplicateConditionalFragments_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Consolidate Duplicate Conditional Fragments");
            bool isPremium = true;
            double price = 100;
            string label;
            if (isPremium) { price *= 0.8; label = "Premium"; }
            else           { price *= 0.9; label = "Regular"; }
            // Moved outside: no duplicate
            Console.WriteLine("  " + label + " price: " + price);
        }
    }
}
