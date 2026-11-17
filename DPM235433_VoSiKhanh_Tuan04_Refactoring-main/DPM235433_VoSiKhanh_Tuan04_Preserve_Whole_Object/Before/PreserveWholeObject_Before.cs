using System;
namespace DPM235433_VoSiKhanh_Tuan04_Preserve_Whole_Object
{
    public class TempRange { public int Low; public int High; }
    public class HeaterPlan { public bool WithinRange(int low, int high) => low >= 10 && high <= 30; }
    public class PreserveWholeObject_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Preserve Whole Object");
            var room = new TempRange { Low = 15, High = 25 };
            var plan = new HeaterPlan();
            // Extracting values from object before passing
            bool ok = plan.WithinRange(room.Low, room.High);
            Console.WriteLine("  Within range: " + ok);
        }
    }
}
