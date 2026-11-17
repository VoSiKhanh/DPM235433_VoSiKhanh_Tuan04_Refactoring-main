using System;
namespace DPM235433_VoSiKhanh_Tuan04_Preserve_Whole_Object
{
    public class DateRange { public DateTime Start; public DateTime End; }
    public class Booking
    {
        public bool IsAvailable(DateRange range)
            => range.End > range.Start && (range.End - range.Start).Days <= 30;
    }
    public class PreserveWholeObject_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Preserve Whole Object - Hotel booking");
            var range = new DateRange { Start = DateTime.Today, End = DateTime.Today.AddDays(7) };
            var booking = new Booking();
            Console.WriteLine("  Available: " + booking.IsAvailable(range));
        }
    }
}
