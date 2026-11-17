using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Parameter_Object
{
    public class OrderParams { public double Price; public int Qty; public double Tax; public double Shipping; }
    public class IntroduceParameterObject_After
    {
        public double GetTotal(OrderParams o) => o.Price * o.Qty + o.Tax + o.Shipping;
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Introduce Parameter Object - clean params");
            var order = new OrderParams { Price = 10.0, Qty = 3, Tax = 2.5, Shipping = 5.0 };
            Console.WriteLine("  Total: $" + GetTotal(order));
        }
    }
}
