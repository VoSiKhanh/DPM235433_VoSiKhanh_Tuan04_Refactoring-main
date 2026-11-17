using System;
namespace DPM235433_VoSiKhanh_Tuan04_Separate_Query_from_Modifier
{
    public class SeparateQueryfromModifier_Before
    {
        private int _level = 0;
        public string GetAndSetLevel() // does both: query + modify
        {
            _level++;
            return "Level: " + _level;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Separate Query from Modifier");
            Console.WriteLine("  " + GetAndSetLevel());
        }
    }
}
