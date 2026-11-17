using System;
namespace DPM235433_VoSiKhanh_Tuan04_Consolidate_Duplicate_Conditional_Fragments
{
    public class ConsolidateDuplicateConditionalFragments_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Consolidate Duplicate Conditional Fragments - Shipping");
            bool isExpress = false;
            double weight = 5.0;
            double fee;
            string type;
            if (isExpress) { fee = weight * 3.0; type = "Express"; }
            else           { fee = weight * 1.0; type = "Standard"; }
            Console.WriteLine("  " + type + " shipping fee: $" + fee);
        }
    }
}
