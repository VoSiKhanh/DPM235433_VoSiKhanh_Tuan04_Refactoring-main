using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Subclass
{
    public class Notification { public string Message;
        public Notification(string m){Message=m;}
        public virtual void Send() => Console.WriteLine("  Notification: "+Message); }
    public class EmailNotification : Notification { public string Email;
        public EmailNotification(string m, string e):base(m){Email=e;}
        public override void Send() => Console.WriteLine("  Email to "+Email+": "+Message); }
    public class ExtractSubclass_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Extract Subclass - Email notification subclass");
            new Notification("System alert").Send();
            new EmailNotification("Order shipped", "user@email.com").Send();
        }
    }
}
