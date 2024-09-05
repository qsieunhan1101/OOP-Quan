﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Quan.Entity;

namespace OOP_Quan.Dao
{
    internal class CategoryDao
    {
        Database databaseTest = new Database();
        public void insert(EntityType entityType ,IEntity row)
        {
            databaseTest.insertTable(entityType, row);

        }
        public void update(EntityType entityType, IEntity row)
        {
            databaseTest.updateTable(entityType, row);
        }
        public void delete(EntityType entityType ,IEntity row)
        {
            databaseTest.deleteTable(entityType, row.Id);
        }
        public List<IEntity> findAll(EntityType entityType)
        {
            List<IEntity> table = databaseTest.selectTable(entityType);
            return table;
        }
        public IEntity findById(EntityType entityType ,int id)
        {
            IEntity c = databaseTest.getIEntityById(entityType, id);
            if (c == null)
            {
                Console.WriteLine("Can not find the Category");
            }
            return c;
        }
    }
}
