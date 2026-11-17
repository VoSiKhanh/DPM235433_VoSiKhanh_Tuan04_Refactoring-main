using System;
namespace DPM235433_VoSiKhanh_Tuan04_Remove_Control_Flag
{
    public class RemoveControlFlag_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Remove Control Flag");
            int[] numbers = { 3, 7, 2, 9, 5 };
            bool found = false;
            int target = 9;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!found)
                {
                    if (numbers[i] == target) { found = true; Console.WriteLine("  Found " + target + " at index " + i); }
                }
            }
        }
    }
}
