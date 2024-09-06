﻿
using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;

namespace OOP_Quan.Demo
{
    internal class CategoryDaoDemo
    {
        public static void Main(string[] args)
        {
            BaseDao BaseDao = new CategoryDao();
            initCategoryTable(BaseDao);
            insertTest(BaseDao, EntityType.Category, new Category(19, "categogogogo"));
            List<BaseRow> d = BaseDao.findAll(EntityType.Category);
            updateTest(BaseDao, EntityType.Category, new Category(19, "asdawwff"));


            deleteTest(BaseDao, EntityType.Category, new Category(19, "asdawwff"));

        }

        static void insertTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.insert(entityType, row);


        }
        static void updateTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.update(entityType, row);
            printTable(BaseDao, EntityType.Category);

        }
        static void deleteTest(BaseDao BaseDao, EntityType entityType, BaseRow row)
        {
            BaseDao.delete(entityType, row);
            printTable(BaseDao, EntityType.Category);
        }


        static void printTable(BaseDao BaseDao, EntityType entityType)
        {
            List<BaseRow> cate = BaseDao.findAll(entityType);
            for (int i = 0; i < cate.Count; i++)
            {
                printTableTest(cate[i]);
            }
        }
        static void printTableTest(BaseRow row)
        {
            Console.Write("Id:" + row.Id);
            Console.Write(" Name:" + row.Name);
            Console.Write("   ");
            Console.Write("\n");
        }

        static void initCategoryTable(BaseDao BaseDao)
        {
            for (int i = 0; i < 6; i++)
            {
                Category cate = new Category(i, $"Category {i}");
                insertTest(BaseDao, EntityType.Category, cate);
            }
        }
    }
}
