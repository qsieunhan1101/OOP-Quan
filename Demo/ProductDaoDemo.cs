using OOP_Quan.Dao;
using OOP_Quan.Entity;
using OOP_Quan.Demo;
using System.Collections.Generic;
using System;

namespace OOP_Quan.Demo
{
    internal class ProductDaoDemo : BaseDaoDemo
    {
        public static void Main(string[] args)
        {
            ProductDaoDemo productDaoDemo = new ProductDaoDemo();
            BaseDao BaseDao = new ProductDao();
            productDaoDemo.initCategoryTable(BaseDao);

            productDaoDemo.insertTest(BaseDao, EntityType.Category, new Category(19, "oooooooooooooooooooooooooooooooooooo"));


            List<BaseRow> d = BaseDao.findAll(EntityType.Category);
            productDaoDemo.updateTest(BaseDao, EntityType.Category, new Category(19, "ffffffffffffffffffffffffffffffffffffffffffff"));
            productDaoDemo.deleteTest(BaseDao, EntityType.Category, new Category(2, "asdawwff"));
        }
    }
}
