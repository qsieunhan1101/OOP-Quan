using OOP_Quan.Dao;
using OOP_Quan.Demo;
using System;
using System.Collections.Generic;

namespace OOP_Quan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database database = new Database();
            ProductDemo productDemo = new ProductDemo();

            IEntity pp = new Product();

            for (int i = 0; i < 5; i++)
            {
                Product p = productDemo.createProductTest();
                p.id = i;
                p.name = $"Product {i}";
                p.categoryId = i + new Random().Next(1,10);
                database.insertTable("product", p);
                productDemo.printProduct(p);
            }
            List<IEntity> tableProduct = database.selectTable("product", 10);
            pp = tableProduct[1];
            productDemo.printProduct((Product)pp);
            
            Product newPro = productDemo.createProductTest(2, "newProduct", 2000);
            database.updateTable("product", newPro);

            tableProduct = database.selectTable("product", 10);
            productDemo.printProduct((Product)tableProduct[2]);

            database.deleteTable("product", tableProduct[2]);
            tableProduct = database.selectTable("product", 10);
            Console.WriteLine("---------");
            productDemo.printProduct((Product)tableProduct[2]);

        }
    }
}
