using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Explicit_Methods
{
    public class ReplaceParameterwithExplicitMethods_After
    {
        public void SetHeight(int value) => Console.WriteLine("  Height set to: " + value);
        public void SetWidth(int value)  => Console.WriteLine("  Width set to: " + value);
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Parameter with Explicit Methods");
            SetHeight(100); SetWidth(200);
        }
    }
}
