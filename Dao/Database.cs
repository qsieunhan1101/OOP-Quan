using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace OOP_Quan.Dao
{
    public class Database
    {
       
        Dictionary<EntityType, List<IEntity>> databaseDictionary = new Dictionary<EntityType, List<IEntity>>()
        {
            {EntityType.Product, new List<IEntity>() {} },
            {EntityType.Category, new List<IEntity>() {} },
            {EntityType.Accessory, new List<IEntity>() {} }
        };


        public int insertTable(EntityType entityType, IEntity row)
        {

            databaseDictionary[entityType].Add(row);
            //Console.WriteLine($"Chen thanh cong {row.Id}");
            return row.Id;
        }
        public List<IEntity> selectTable(EntityType entityType)
        {
            return databaseDictionary[entityType];
        }
        public int updateTable(EntityType entityType, IEntity row)
        {
            for (int i= 0; i< databaseDictionary[entityType].Count; i++)
            {
                if (databaseDictionary[entityType][i].Id == row.Id )
                {
                    databaseDictionary[entityType][i] = row;
                    Console.WriteLine($"Update thanh cong {row.Id}");

                }
            }
            return row.Id;
        }
        public void deleteTable(EntityType entityType, int id)
        {
            List<IEntity> table = databaseDictionary[entityType];
            for (int i= 0;i<table.Count;i++)
            {
                if (table[i].Id == id)
                {
                    databaseDictionary[entityType].Remove(databaseDictionary[entityType][i]);
                }
            }


            
        }
        public void truncateTable(EntityType entityType)
        {
            databaseDictionary[entityType].Clear();
        }

        public void updateTableById(EntityType entityType, int id, IEntity row)
        {
            List<IEntity> table = databaseDictionary[entityType];
            for (int i = 0; i < table.Count - 1; i++)
            {
                if (table[i].Id == id)
                {
                    databaseDictionary[entityType][i] = row;
                }
            }
        }

        public IEntity getIEntityById(EntityType entityType,int id) 
        {
            List<IEntity> table = databaseDictionary[entityType];
            for (int i = 0; i<table.Count-1; i++)
            {
                if (table[i].Id == id)
                {
                    return databaseDictionary[entityType][i];
                }

            }
            return null;
        }

    }
}
