using OOP_Quan.Entity;
using System;
using System.Collections.Generic;

namespace OOP_Quan.Dao
{
    public class Database
    {
        private static Database instance;

        public static Database Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Database();
                }
                return instance;
            }
        }



        private Dictionary<EntityType, List<BaseRow>> databaseDictionary = new Dictionary<EntityType, List<BaseRow>>()
        {
            {EntityType.Product, new List<BaseRow>() {} },
            {EntityType.Category, new List<BaseRow>() {} },
            {EntityType.Accessory, new List<BaseRow>() {} }
        };


        public int insertTable(EntityType entityType, BaseRow row)
        {

            databaseDictionary[entityType].Add(row);
            //Console.WriteLine($"Chen thanh cong {row.Id}");
            return row.Id;
        }
        public List<BaseRow> selectTable(EntityType entityType)
        {
            return databaseDictionary[entityType];
        }
        public int updateTable(EntityType entityType, BaseRow row)
        {
            for (int i = 0; i < databaseDictionary[entityType].Count; i++)
            {
                if (databaseDictionary[entityType][i].Id == row.Id)
                {
                    databaseDictionary[entityType][i] = row;
                    Console.WriteLine($"Update thanh cong {row.Id}");

                }
            }
            return row.Id;
        }
        public void deleteTable(EntityType entityType, int id)
        {
            List<BaseRow> table = databaseDictionary[entityType];
            for (int i = 0; i < table.Count; i++)
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

        public void updateTableById(EntityType entityType, int id, BaseRow row)
        {
            List<BaseRow> table = databaseDictionary[entityType];
            for (int i = 0; i < table.Count - 1; i++)
            {
                if (table[i].Id == id)
                {
                    databaseDictionary[entityType][i] = row;
                }
            }
        }

        public BaseRow getIEntityById(EntityType entityType, int id)
        {
            List<BaseRow> table = databaseDictionary[entityType];
            for (int i = 0; i < table.Count - 1; i++)
            {
                if (table[i].Id == id)
                {
                    return databaseDictionary[entityType][i];
                }

            }
            return null;
        }

        public BaseRow getIEntityByName(EntityType entityType, string name)
        {
            List<BaseRow> table = databaseDictionary[entityType];
            for (int i = 0; i < table.Count - 1; i++)
            {
                if (table[i].Name == name)
                {
                    return databaseDictionary[entityType][i];
                }

            }
            return null;
        }
    }
}
