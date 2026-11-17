using System;
using System.Collections.Generic;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Inheritance_with_Delegation
{
    public class EventQueue
    {
        private Queue<string> _queue = new Queue<string>();
        public void Enqueue(string evt) => _queue.Enqueue(evt);
        public string Dequeue() => _queue.Count > 0 ? _queue.Dequeue() : null;
        public int Count => _queue.Count;
    }
    public class ReplaceInheritancewithDelegation_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Inheritance with Delegation - Event queue");
            var q = new EventQueue();
            q.Enqueue("UserLoggedIn"); q.Enqueue("OrderPlaced");
            Console.WriteLine("  Event: " + q.Dequeue());
            Console.WriteLine("  Remaining: " + q.Count);
        }
    }
}
