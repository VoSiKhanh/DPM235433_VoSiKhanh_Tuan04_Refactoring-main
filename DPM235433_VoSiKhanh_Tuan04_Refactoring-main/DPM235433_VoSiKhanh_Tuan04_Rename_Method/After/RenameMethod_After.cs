using System;
namespace DPM235433_VoSiKhanh_Tuan04_Rename_Method
{
    public class RenameMethod_After
    {
        public int GetPhoneNumberLength(string phoneNumber) => phoneNumber.Length; // clear name
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Rename Method - clear method name 'GetPhoneNumberLength'");
            Console.WriteLine("  Phone length: " + GetPhoneNumberLength("0123456789"));
        }
    }
}
