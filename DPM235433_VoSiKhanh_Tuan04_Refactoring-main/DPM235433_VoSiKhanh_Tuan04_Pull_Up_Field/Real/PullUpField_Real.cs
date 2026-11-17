using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Field
{
    public abstract class Vehicle { public string Brand; public int Year; public Vehicle(string b, int y){Brand=b;Year=y;} }
    public class Car   : Vehicle { public Car(string b, int y):base(b,y){} }
    public class Truck : Vehicle { public Truck(string b, int y):base(b,y){} }
    public class PullUpField_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Pull Up Field - Vehicle brand and year in base class");
            Vehicle[] vehicles = { new Car("Toyota", 2020), new Truck("Ford", 2019) };
            foreach (var v in vehicles) Console.WriteLine("  " + v.GetType().Name + ": " + v.Brand + " " + v.Year);
        }
    }
}
