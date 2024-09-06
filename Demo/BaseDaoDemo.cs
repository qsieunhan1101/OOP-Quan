using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
                printRow(cate[i]);
            }
        }
        public void printRow(BaseRow row)
        {
            Console.Write("Id:" + row.Id);
            Console.Write(" Name:" + row.Name);
            Console.Write("   ");
            Console.Write("\n");
        }

        public void initCategoryTable(EntityType entityType,BaseDao BaseDao)
        {
            for (int i = 0; i < 6; i++)
            {
                Category cate = new Category(i, $"Category {i}");
                insertTest(BaseDao, entityType, cate);
            }
        }
    }
}
