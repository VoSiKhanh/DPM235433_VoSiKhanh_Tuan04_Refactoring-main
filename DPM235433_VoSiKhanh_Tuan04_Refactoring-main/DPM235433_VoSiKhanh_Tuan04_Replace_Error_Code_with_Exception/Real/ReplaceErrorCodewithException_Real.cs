using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Error_Code_with_Exception
{
    public class ReplaceErrorCodewithException_Real
    {
        public int ParseAge(string input)
        {
            int age = int.Parse(input);
            if (age < 0 || age > 150) throw new ArgumentOutOfRangeException("age", "Age must be 0-150");
            return age;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Error Code with Exception - Age parser");
            try { Console.WriteLine("  Age: " + ParseAge("25")); ParseAge("200"); }
            catch (ArgumentOutOfRangeException ex) { Console.WriteLine("  Error: " + ex.Message); }
        }
    }
}
