using System;
namespace DPM235433_VoSiKhanh_Tuan04_Preserve_Whole_Object
{
    public class HeaterPlanNew
    {
        public bool WithinRange(TempRange range) => range.Low >= 10 && range.High <= 30;
    }
    public class PreserveWholeObject_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Preserve Whole Object");
            var room = new TempRange { Low = 15, High = 25 };
            var plan = new HeaterPlanNew();
            // Pass the whole object
            bool ok = plan.WithinRange(room);
            Console.WriteLine("  Within range: " + ok);
        }
    }
}
