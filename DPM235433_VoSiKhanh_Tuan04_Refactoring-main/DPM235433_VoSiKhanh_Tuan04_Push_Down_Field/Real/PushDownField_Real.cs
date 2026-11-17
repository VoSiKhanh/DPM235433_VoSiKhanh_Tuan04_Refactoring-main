using System;
namespace DPM235433_VoSiKhanh_Tuan04_Push_Down_Field
{
    public abstract class Device { public string SerialNumber; public Device(string s){SerialNumber=s;} }
    public class Printer : Device { public int PageCount; // only Printer has PageCount
        public Printer(string s, int p):base(s){PageCount=p;}
        public void Print() => Console.WriteLine("  Printer "+SerialNumber+" printed "+PageCount+" pages"); }
    public class Scanner : Device { public Scanner(string s):base(s){} }
    public class PushDownField_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Push Down Field - PageCount only in Printer");
            new Printer("SN-001", 150).Print();
        }
    }
}
