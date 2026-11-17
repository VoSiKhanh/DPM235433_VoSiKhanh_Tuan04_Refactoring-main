using System;
namespace DPM235433_VoSiKhanh_Tuan04_Pull_Up_Field
{
    public class DogBefore  { public string Name; public DogBefore(string n){Name=n;} }
    public class CatBefore  { public string Name; public CatBefore(string n){Name=n;} }
    public class PullUpField_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Pull Up Field - Name duplicated in Dog and Cat");
            var dog = new DogBefore("Rex"); var cat = new CatBefore("Whiskers");
            Console.WriteLine("  Dog: " + dog.Name + " | Cat: " + cat.Name);
        }
    }
}
