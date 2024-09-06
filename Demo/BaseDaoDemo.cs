using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Demo
{
    public abstract class BaseDaoDemo
    {
        public void insertTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.insert(entityType, row);


        }
        public void updateTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.update(entityType, row);
            printTable(BaseDao, EntityType.Category);

        }
        public void deleteTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.delete(entityType, row);
            printTable(BaseDao, EntityType.Category);
        }


        public void printTable(BaseDao BaseDao, EntityType entityType)
        {
            List<BaseRow> cate = BaseDao.findAll(entityType);
            for (int i = 0; i < cate.Count; i++)
            {
                printTableTest(cate[i]);
            }
        }
        public void printTableTest(BaseRow row)
        {
            Console.Write("Id:" + row.Id);
            Console.Write(" Name:" + row.Name);
            Console.Write("   ");
            Console.Write("\n");
        }

        public void initCategoryTable(BaseDao BaseDao)
        {
            for (int i = 0; i < 6; i++)
            {
                Category cate = new Category(i, $"Category {i}");
                insertTest(BaseDao, EntityType.Category, cate);
            }
        }
    }
}
