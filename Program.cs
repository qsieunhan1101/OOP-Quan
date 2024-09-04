using OOP_Quan.Dao;
using OOP_Quan.Demo;
using System;

namespace OOP_Quan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            ProductDemo productDemo = new ProductDemo();
            for (int i = 0; i < 5; i++)
            {
                Product p = productDemo.createProductTest();
                p.id = i;
                p.name = $"Product {i}";
                p.categoryId = i;
                database.insertTable("product", p);
                productDemo.printProduct(p);
            }
            database.selectTable("product", 10);
        }
    }
}
