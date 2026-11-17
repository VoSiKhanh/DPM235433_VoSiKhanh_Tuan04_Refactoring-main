using System;
namespace DPM235433_VoSiKhanh_Tuan04_Form_Template_Method
{
    public abstract class DataProcessor
    {
        public void Process() { ReadData(); ProcessData(); WriteData(); } // template
        protected abstract void ReadData();
        protected abstract void ProcessData();
        protected void WriteData() => Console.WriteLine("  Writing results to output");
    }
    public class CsvProcessor : DataProcessor
    {
        protected override void ReadData() => Console.WriteLine("  Reading CSV file");
        protected override void ProcessData() => Console.WriteLine("  Parsing CSV rows");
    }
    public class FormTemplateMethod_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Form Template Method - Data processing pipeline");
            new CsvProcessor().Process();
        }
    }
}
