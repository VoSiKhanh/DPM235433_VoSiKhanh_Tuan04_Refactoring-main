using System;
namespace DPM235433_VoSiKhanh_Tuan04_Rename_Method
{
    public class RenameMethod_Before
    {
        public int phon(string phoneNumber) => phoneNumber.Length; // unclear name
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Rename Method - unclear method name 'phon'");
            Console.WriteLine("  Result: " + phon("0123456789"));
        }
    }
}
