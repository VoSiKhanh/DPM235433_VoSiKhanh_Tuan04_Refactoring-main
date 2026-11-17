using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Setting_Method
{
    public class RemoveSettingMethod_After
    {
        public string Name { get; } // read-only — cannot be changed after creation
        public RemoveSettingMethod_After(string name) { Name = name; }
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Remove Setting Method");
            var obj = new RemoveSettingMethod_After("Alice");
            // obj.Name = "Bob"; // Compile error — immutable!
            Console.WriteLine("  Name (immutable): " + obj.Name);
        }
    }
}
