using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Control_Flag
{
    public class RemoveControlFlag_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Remove Control Flag - Find first invalid input");
            string[] inputs = { "Alice", "Bob", "", "Charlie" };
            foreach (var name in inputs)
            {
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("  Invalid input found: empty string");
                    break;
                }
            }
        }
    }
}
