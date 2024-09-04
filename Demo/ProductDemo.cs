using OOP_Quan.Entity;
using System;

namespace OOP_Quan.Demo
{
    internal class ProductDemo
    {

        public Product createProductTest()
        {
            Product p = new Product();
/*            int id = System.Int32.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int category = System.Int32.Parse(Console.ReadLine());
            p.id = id;
            p.name = name;
            p.categoryId = category;*/

            return p;

        }
        public void printProduct(Product product)
        {
            Console.WriteLine("id: "+product.id);
            Console.WriteLine(product.name);
            Console.WriteLine("category: " + product.categoryId + "\n");
        }
    }
}

