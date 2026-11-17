using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Duplicate_Conditional_Fragments
{
    public class ConsolidateDuplicateConditionalFragments_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Consolidate Duplicate Conditional Fragments");
            bool isPremium = true;
            double price = 100;
            if (isPremium)
            {
                price = price * 0.8;
                Console.WriteLine("  Premium price: " + price); // duplicated
            }
            else
            {
                price = price * 0.9;
                Console.WriteLine("  Regular price: " + price); // duplicated logic
            }
        }
    }
}
