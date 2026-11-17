using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Field
{
    public abstract class AnimalAfter { public string Name; public AnimalAfter(string n){Name=n;} }
    public class DogAfter : AnimalAfter { public DogAfter(string n):base(n){} }
    public class CatAfter : AnimalAfter { public CatAfter(string n):base(n){} }
    public class PullUpField_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Pull Up Field - Name moved to AnimalAfter base class");
            AnimalAfter[] animals = { new DogAfter("Rex"), new CatAfter("Whiskers") };
            foreach (var a in animals) Console.WriteLine("  " + a.GetType().Name + ": " + a.Name);
        }
    }
}
