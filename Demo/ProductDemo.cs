using OOP_Quan;
using System;

namespace OOP_Quan.Demo
{
    internal class ProductDemo
    {
        
/*        public static void Main(string[] args)
        {
            Product product = createProductTest();
            printProduct(product);
        }*/
        public static Product createProductTest()
        {
            Product product = new Product(10, "pro 1", 15);
            return product;
        }

        public void printProduct(Product product)
        {
            Console.WriteLine("Id:" + product.Id);
            Console.WriteLine("Name:" + product.Name);
            Console.WriteLine("CategoryId:" + product.CategoryId);
        }
    }
}

