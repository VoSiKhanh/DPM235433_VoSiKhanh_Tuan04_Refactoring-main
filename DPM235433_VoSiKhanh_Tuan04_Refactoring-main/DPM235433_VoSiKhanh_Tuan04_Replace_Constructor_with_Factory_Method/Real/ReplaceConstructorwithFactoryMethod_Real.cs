using System;
namespace DPM235433_VoSiKhanh_Tuan04_Replace_Constructor_with_Factory_Method
{
    public abstract class DbConnection { public abstract string Connect(); }
    public class MySqlConnection : DbConnection { public override string Connect() => "Connected to MySQL"; }
    public class SqliteConnection: DbConnection { public override string Connect() => "Connected to SQLite"; }
    public class DbFactory
    {
        public static DbConnection Create(string type)
        {
            if (type == "mysql") return new MySqlConnection();
            return new SqliteConnection();
        }
    }
    public class ReplaceConstructorwithFactoryMethod_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Replace Constructor with Factory Method - DB connections");
            Console.WriteLine("  " + DbFactory.Create("mysql").Connect());
            Console.WriteLine("  " + DbFactory.Create("sqlite").Connect());
        }
    }
}
