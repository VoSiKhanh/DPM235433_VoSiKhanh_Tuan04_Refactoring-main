using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Null_Object
{
    public abstract class AbstractCustomer { public abstract string GetName(); }
    public class RealCustomer : AbstractCustomer { private string _name; public RealCustomer(string n){_name=n;} public override string GetName() => _name; }
    public class NullCustomer : AbstractCustomer { public override string GetName() => "Guest"; }

    public class IntroduceNullObject_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Introduce Null Object");
            AbstractCustomer customer = new NullCustomer(); // no null checks needed
            Console.WriteLine("  Customer name: " + customer.GetName());
        }
    }
}
