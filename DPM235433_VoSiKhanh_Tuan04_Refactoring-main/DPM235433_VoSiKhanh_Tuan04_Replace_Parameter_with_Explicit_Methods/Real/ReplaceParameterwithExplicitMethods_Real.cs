using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Parameter_with_Explicit_Methods
{
    public class ReplaceParameterwithExplicitMethods_Real
    {
        public void ActivateAccount()   => Console.WriteLine("  Account: ACTIVE");
        public void DeactivateAccount() => Console.WriteLine("  Account: INACTIVE");
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Parameter with Explicit Methods - Account management");
            ActivateAccount(); DeactivateAccount();
        }
    }
}
