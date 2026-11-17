using System;
namespace DPM235433_VoSiKhanh_Tuan04_Extract_Interface
{
    public interface IExporter { void Export(string data); }
    public class CsvExporter  : IExporter { public void Export(string d) => Console.WriteLine("  CSV: "+d); }
    public class JsonExporter : IExporter { public void Export(string d) => Console.WriteLine("  JSON: {\"data\":\""+d+"\"}"); }
    public class ReportService { private IExporter _exp; public ReportService(IExporter e){_exp=e;}
        public void GenerateReport(string data) { Console.WriteLine("  Generating..."); _exp.Export(data); } }
    public class ExtractInterface_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Extract Interface - IExporter for multiple formats");
            new ReportService(new CsvExporter()).GenerateReport("Sales Q1");
            new ReportService(new JsonExporter()).GenerateReport("Sales Q1");
        }
    }
}
