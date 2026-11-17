using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Setting_Method
{
    public class RemoveSettingMethod_Before
    {
        public string Name { get; set; } // settable — but should be immutable
        public RemoveSettingMethod_Before(string name) { Name = name; }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Remove Setting Method");
            var obj = new RemoveSettingMethod_Before("Alice");
            obj.Name = "Bob"; // Name changed after creation — bad!
            Console.WriteLine("  Name: " + obj.Name);
        }
    }
}
