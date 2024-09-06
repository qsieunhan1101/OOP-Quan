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
            EntityType name = EntityType.Product;

            ProductDaoDemo productDaoDemo = new ProductDaoDemo();
            BaseDao BaseDao = new ProductDao();
            productDaoDemo.initCategoryTable(name,BaseDao);

            productDaoDemo.insertTest(BaseDao, name, new Category(19, "oooooooooooooooooooooooooooooooooooo"));


            List<BaseRow> d = BaseDao.findAll(name);
            productDaoDemo.updateTest(BaseDao, name, new Category(19, "ffffffffffffffffffffffffffffffffffffffffffff"));
            productDaoDemo.deleteTest(BaseDao, name, new Category(2, "asdawwff"));
        }
    }
}
