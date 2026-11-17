using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Conditional_with_Polymorphism
{
    public abstract class Bird { public abstract double GetSpeed(); }
    public class EuropeanSwallow : Bird { public override double GetSpeed() => 35.0; }
    public class AfricanSwallow  : Bird { public override double GetSpeed() => 25.0; }
    public class NorwegianBlue   : Bird { public override double GetSpeed() => 18.0; }

    public class ReplaceConditionalwithPolymorphism_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Conditional with Polymorphism");
            Bird[] birds = { new EuropeanSwallow(), new AfricanSwallow() };
            foreach (var b in birds)
                Console.WriteLine("  Speed: " + b.GetSpeed());
        }
    }
}
