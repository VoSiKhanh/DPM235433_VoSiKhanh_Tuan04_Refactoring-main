using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Control_Flag
{
    public class RemoveControlFlag_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Remove Control Flag");
            int[] numbers = { 3, 7, 2, 9, 5 };
            int target = 9;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    Console.WriteLine("  Found " + target + " at index " + i);
                    break; // use break instead of flag
                }
            }
        }
    }
}
