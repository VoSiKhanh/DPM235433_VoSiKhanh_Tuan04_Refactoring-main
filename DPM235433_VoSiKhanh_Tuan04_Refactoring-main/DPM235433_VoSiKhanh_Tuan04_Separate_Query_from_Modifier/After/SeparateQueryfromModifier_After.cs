using System;
namespace DPM235433_VoSiKhanh_Tuan04_Separate_Query_from_Modifier
{
    public class SeparateQueryfromModifier_After
    {
        private int _level = 0;
        public string GetLevel() => "Level: " + _level;  // query only
        public void IncrementLevel() { _level++; }        // modifier only
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Separate Query from Modifier");
            IncrementLevel();
            Console.WriteLine("  " + GetLevel());
        }
    }
}
