using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OOP_Quan.Dao
{
    public class Database : Singleton<Database>
    {
        private Dictionary<EntityType, List<BaseRow>> databaseDictionary = new Dictionary<EntityType, List<BaseRow>>()
        {
            {EntityType.Product, new List<BaseRow>() {} },
            {EntityType.Category, new List<BaseRow>() {} },
            {EntityType.Accessory, new List<BaseRow>() {} }
        };

        /// <summary>
        /// Them mot object vao bang tuong ung theo key cua bang
        /// </summary>
        /// <param name="entityType">Ten cua bang can truy cap</param>
        /// <param name="row">object can them vao bang</param>
        /// <returns></returns>
        public int insertTable(EntityType entityType, BaseRow row)
        {
            databaseDictionary[entityType].Add(row);
            //Console.WriteLine($"Chen thanh cong {row.Id}");
            return row.Id;
        }
        /// <summary>
        /// Lay ra bang can truy cap
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <returns></returns>
        public List<BaseRow> selectTable(EntityType entityType)
        {
            return databaseDictionary[entityType];
        }
        /// <summary>
        /// Cap nhan lai bang theo object
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="row">object can thay the</param>
        /// <returns></returns>
        public int updateTable(EntityType entityType, BaseRow row)
        {
            for (int i = 0; i < databaseDictionary[entityType].Count; i++)
            {
                if (databaseDictionary[entityType][i].Id == row.Id)
                {
                    databaseDictionary[entityType][i] = row;

                }
            }
            return row.Id;
        }
        /// <summary>
        /// Xoa mot object khoi bang
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="id">id cua object can xoa</param>
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

        /// <summary>
        /// Xoa toan bo can phan tu trong bang
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        public void truncateTable(EntityType entityType)
        {
            databaseDictionary[entityType].Clear();
        }
        /// <summary>
        /// Cap nhat bang theo Id
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="id">Id cua doi tuong can cap nhat</param>
        /// <param name="row">object thay the</param>
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
        /// <summary>
        /// Lay mot object theo id
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="id">id cua object can lay</param>
        /// <returns></returns>
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
        /// <summary>
        /// Lay mot object theo ten
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="name">Ten object muon lay</param>
        /// <returns></returns>
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
