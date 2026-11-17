using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Conditional_with_Polymorphism
{
    public abstract class Shape { public abstract double Area(); }
    public class Circle    : Shape { private double r; public Circle(double r){this.r=r;} public override double Area() => Math.PI * r * r; }
    public class Rectangle : Shape { private double w,h; public Rectangle(double w,double h){this.w=w;this.h=h;} public override double Area() => w*h; }

    public class ReplaceConditionalwithPolymorphism_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Conditional with Polymorphism - Shapes");
            Shape[] shapes = { new Circle(5), new Rectangle(4, 6) };
            foreach (var s in shapes)
                Console.WriteLine("  " + s.GetType().Name + " area: " + Math.Round(s.Area(), 2));
        }
    }
}
