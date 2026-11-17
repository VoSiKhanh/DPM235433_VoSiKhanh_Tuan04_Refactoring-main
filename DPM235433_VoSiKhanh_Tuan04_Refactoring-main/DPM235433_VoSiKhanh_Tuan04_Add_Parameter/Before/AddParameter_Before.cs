using System;
namespace DPM235433_VoSiKhanh_Tuan04_Add_Parameter
{
    public class AddParameter_Before
    {
        public string GetCustomer() => "Default Customer"; // no parameter, limited
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Add Parameter");
            Console.WriteLine("  " + GetCustomer());
        }
    }
}
