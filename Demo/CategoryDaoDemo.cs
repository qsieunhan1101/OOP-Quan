
using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;

namespace OOP_Quan.Demo
{
    internal class CategoryDaoDemo : BaseDaoDemo
    {
        public static void Main(string[] args)
        {
            EntityType name = EntityType.Category;

            CategoryDaoDemo categoryDaoDemo = new CategoryDaoDemo();
            CategoryDao categoryDao = new CategoryDao();
            Console.WriteLine($"-----------Khoi tao bang {name}");
            categoryDaoDemo.initCategoryTable(name, categoryDao);
            categoryDaoDemo.printTable(categoryDao, name);

            Console.WriteLine($"-------------Chen phan tu moi vao bang {name}");
            categoryDaoDemo.insertTest(categoryDao, name, new Category(19, "categogogogo"));
            categoryDaoDemo.printTable(categoryDao, name);


            Console.WriteLine($"-------------Update bang {name}");
            categoryDaoDemo.updateTest(categoryDao, name, new Category(3, "asdawwff"));

            Console.WriteLine($"--------------Xoa phan tu trong bang {name}");

            categoryDaoDemo.deleteTest(categoryDao, name, new Category(19, "categogogogo"));


            Console.WriteLine("--------------------Test FindbyNAme");
            BaseRow fbname = categoryDao.findByName("Category 2");
            Console.Write("Id:" + fbname.Id);
            Console.Write(" Name:" + fbname.Name);
            Console.Write("   ");
            Console.Write("\n");




            Console.WriteLine("--------------------Test Search");


            List<BaseRow> listTag = categoryDao.search("Category");
            for (int i = 0; i < listTag.Count; i++)
            {
                Console.Write("Id:" + listTag[i].Id);
                Console.Write(" Name:" + listTag[i].Name);
                Console.Write("   ");
                Console.Write("\n");

            }
        }



    }
}
