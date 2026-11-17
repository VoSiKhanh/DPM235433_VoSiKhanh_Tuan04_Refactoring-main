using System;
using System.Collections;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Inheritance_with_Delegation
{
    public class MyStack : ArrayList // wrong: Stack inherits all ArrayList methods
    {
        public void Push(object item) => Add(item);
        public object Pop() { var item = this[Count-1]; RemoveAt(Count-1); return item; }
    }
    public class ReplaceInheritancewithDelegation_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Replace Inheritance with Delegation");
            var stack = new MyStack();
            stack.Push("A"); stack.Push("B");
            Console.WriteLine("  Pop: " + stack.Pop());
        }
    }
}
