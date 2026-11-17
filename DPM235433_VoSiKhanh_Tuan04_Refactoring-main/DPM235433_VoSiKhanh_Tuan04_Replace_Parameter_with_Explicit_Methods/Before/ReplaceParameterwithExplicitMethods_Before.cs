using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Explicit_Methods
{
    public class ReplaceParameterwithExplicitMethods_Before
    {
        public void SetValue(string param, int value)
        {
            if (param == "height") Console.WriteLine("  Height set to: " + value);
            else if (param == "width") Console.WriteLine("  Width set to: " + value);
        }
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Parameter with Explicit Methods");
            SetValue("height", 100); SetValue("width", 200);
        }
    }
}
