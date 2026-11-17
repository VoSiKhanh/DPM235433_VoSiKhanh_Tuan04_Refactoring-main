using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Null_Object
{
    public class Customer { public string Name; public Customer(string name){Name=name;} }
    public class IntroduceNullObject_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Introduce Null Object");
            Customer customer = null;
            // Must check null everywhere
            string name = (customer != null) ? customer.Name : "Guest";
            Console.WriteLine("  Customer name: " + name);
        }
    }
}
