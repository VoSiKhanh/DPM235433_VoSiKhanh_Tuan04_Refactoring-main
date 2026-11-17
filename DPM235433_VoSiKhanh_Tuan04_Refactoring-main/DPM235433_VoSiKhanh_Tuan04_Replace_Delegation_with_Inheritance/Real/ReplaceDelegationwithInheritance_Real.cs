using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Delegation_with_Inheritance
{
    public class Logger { public void Log(string msg) => Console.WriteLine("  [LOG] "+msg); }
    public class AuditService : Logger // inherits Logger directly
    {
        public void RecordAction(string action)
        {
            Log("Audit: " + action); // uses inherited method
            Console.WriteLine("  Action recorded: " + action);
        }
    }
    public class ReplaceDelegationwithInheritance_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Delegation with Inheritance - Audit service");
            new AuditService().RecordAction("UserDeleted");
        }
    }
}
