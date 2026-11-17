using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Conditional_with_Polymorphism
{
    public class ReplaceConditionalwithPolymorphism_Before
    {
        public double GetSpeed(string type)
        {
            if (type == "European") return 35.0;
            if (type == "African") return 25.0;
            if (type == "NorwegianBlue") return 18.0;
            throw new Exception("Unknown type");
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Conditional with Polymorphism");
            Console.WriteLine("  European swallow speed: " + GetSpeed("European"));
            Console.WriteLine("  African swallow speed:  " + GetSpeed("African"));
        }
    }
}
