using System;
namespace DPM235433_VoSiKhanh_Tuan04_Add_Parameter
{
    public class AddParameter_After
    {
        public string GetCustomer(int customerId) => "Customer #" + customerId; // added parameter
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Add Parameter");
            Console.WriteLine("  " + GetCustomer(42));
        }
    }
}
