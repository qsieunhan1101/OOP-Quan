using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Demo
{
    internal class EntityDaoDemo
    {

      /*  static void insertTest(EntityDao categoryDao, EntityType entityType, IEntity row)
        {
            categoryDao.insert(entityType, row);


        }
        static void updateTest(CategoryDao categoryDao, EntityType entityType, IEntity row)
        {
            categoryDao.update(entityType, row);
            printTable(categoryDao, EntityType.Category);

        }
        static void deleteTest(CategoryDao categoryDao, EntityType entityType, IEntity row)
        {
            categoryDao.delete(entityType, row);
            printTable(categoryDao, EntityType.Category);
        }


        static void printTable(CategoryDao categoryDao, EntityType entityType)
        {
            List<IEntity> cate = categoryDao.findAll(entityType);
            for (int i = 0; i < cate.Count; i++)
            {
                printTableTest(cate[i]);
            }
        }
        static void printTableTest(IEntity row)
        {
            Console.Write("Id:" + row.Id);
            Console.Write(" Name:" + row.Name);
            Console.Write("   ");
            Console.Write("\n");
        }

        static void initCategoryTable(CategoryDao categoryDao)
        {
            for (int i = 0; i < 6; i++)
            {
                IEntity cate = new Category(i, $"Category {i}");
                insertTest(categoryDao, EntityType.Category, cate);
            }
        }*/
    }
}
