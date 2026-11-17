using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Superclass
{
    public abstract class Animal { public string Name; public int Age;
        public Animal(string n, int a){Name=n;Age=a;}
        public abstract string Speak(); }
    public class Dog : Animal { public Dog(string n, int a):base(n,a){} public override string Speak() => "Woof!"; }
    public class Cat : Animal { public Cat(string n, int a):base(n,a){} public override string Speak() => "Meow!"; }
    public class ExtractSuperclass_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Extract Superclass - Animal base class");
            Animal[] animals = { new Dog("Rex",3), new Cat("Whiskers",5) };
            foreach (var a in animals) Console.WriteLine("  "+a.Name+"("+a.Age+"): "+a.Speak());
        }
    }
}
