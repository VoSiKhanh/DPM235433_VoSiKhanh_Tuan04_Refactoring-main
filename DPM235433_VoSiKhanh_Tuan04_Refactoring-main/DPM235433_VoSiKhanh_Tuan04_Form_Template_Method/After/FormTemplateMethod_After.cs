using System;
namespace DPM235433_VoSiKhanh_Tuan04_Form_Template_Method
{
    public abstract class Migration
    {
        public void Migrate() { Pack(); Hire(); Move(); } // template method
        protected void Pack() => Console.WriteLine("  Pack belongings");
        protected abstract void Hire();
        protected abstract void Move();
    }
    public class ResidentialMigrationNew : Migration
    {
        protected override void Hire() => Console.WriteLine("  Rent truck");
        protected override void Move() => Console.WriteLine("  Move boxes");
    }
    public class OfficeMigrationNew : Migration
    {
        protected override void Hire() => Console.WriteLine("  Hire professional movers");
        protected override void Move() => Console.WriteLine("  Move furniture and equipment");
    }
    public class FormTemplateMethod_After
    {
        public void Demonstrate()
        {
            Console.WriteLine("[AFTER] Form Template Method - shared steps in base class");
            new ResidentialMigrationNew().Migrate();
        }
    }
}
