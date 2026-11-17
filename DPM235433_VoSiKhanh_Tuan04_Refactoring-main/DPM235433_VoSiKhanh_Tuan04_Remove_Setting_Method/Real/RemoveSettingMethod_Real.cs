using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Setting_Method
{
    public class RemoveSettingMethod_Real
    {
        public string OrderId { get; }
        public DateTime CreatedAt { get; }
        public RemoveSettingMethod_Real(string orderId)
        {
            OrderId = orderId;
            CreatedAt = DateTime.Now;
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Remove Setting Method - Immutable Order ID");
            var order = new RemoveSettingMethod_Real("ORD-2024-001");
            Console.WriteLine("  Order: " + order.OrderId + " created: " + order.CreatedAt.ToShortDateString());
        }
    }
}
