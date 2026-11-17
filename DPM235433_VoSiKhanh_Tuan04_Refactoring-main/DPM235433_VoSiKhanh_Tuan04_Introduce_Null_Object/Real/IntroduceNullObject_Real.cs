using System;
namespace DPM235433_VoSiKhanh_Tuan04_Introduce_Null_Object
{
    public interface ILogger { void Log(string msg); }
    public class ConsoleLogger : ILogger { public void Log(string msg) => Console.WriteLine("  LOG: " + msg); }
    public class NullLogger : ILogger { public void Log(string msg) { } } // does nothing

    public class IntroduceNullObject_Real
    {
        private ILogger _logger;
        public IntroduceNullObject_Real(ILogger logger) { _logger = logger; }
        public void ProcessOrder(string item)
        {
            _logger.Log("Processing: " + item);
            Console.WriteLine("  Order processed: " + item);
        }
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Introduce Null Object - Logger");
            var svc = new IntroduceNullObject_Real(new ConsoleLogger());
            svc.ProcessOrder("Book");
        }
    }
}
