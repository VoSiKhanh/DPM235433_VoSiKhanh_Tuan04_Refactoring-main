using System;
namespace DPM235433_VoSiKhanh_Tuan04_Collapse_Hierarchy
{
    public class Product { public string Name; public double Price; public string Category;
        public Product(string name, double price, string category){Name=name;Price=price;Category=category;}
        public void Display() => Console.WriteLine("  ["+Category+"] "+Name+" $"+Price); }
    public class CollapseHierarchy_Real
    {
        public void Demonstrate()
        {
            Console.WriteLine("[REAL] Collapse Hierarchy - Merged product categories into one class");
            new Product("Laptop", 999.99, "Electronics").Display();
            new Product("T-Shirt", 29.99, "Clothing").Display();
        }
    }
}
