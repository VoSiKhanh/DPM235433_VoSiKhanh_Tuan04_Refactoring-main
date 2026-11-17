using System;
using System.Collections;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Inheritance_with_Delegation
{
    public class MyStackNew // uses delegation instead of inheritance
    {
        private ArrayList _list = new ArrayList();
        public void Push(object item) => _list.Add(item);
        public object Pop() { var item = _list[_list.Count-1]; _list.RemoveAt(_list.Count-1); return item; }
        public int Count => _list.Count;
    }
    public class ReplaceInheritancewithDelegation_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Replace Inheritance with Delegation");
            var stack = new MyStackNew();
            stack.Push("A"); stack.Push("B");
            Console.WriteLine("  Pop: " + stack.Pop() + " | Count: " + stack.Count);
        }
    }
}
