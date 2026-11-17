using System;
namespace DPM235433_VoSiKhanh_Tuan04_Form_Template_Method
{
    public class ResidentialMigration { public void Migrate() { Console.WriteLine("  Pack"); Console.WriteLine("  Rent truck"); Console.WriteLine("  Move boxes"); } }
    public class OfficeMigration     { public void Migrate() { Console.WriteLine("  Pack"); Console.WriteLine("  Hire movers"); Console.WriteLine("  Move furniture"); } }
    public class FormTemplateMethod_Before
    {
        public void Demonstrate()
        {
            Console.WriteLine("[BEFORE] Form Template Method - similar steps duplicated");
            new ResidentialMigration().Migrate();
        }
    }
}
