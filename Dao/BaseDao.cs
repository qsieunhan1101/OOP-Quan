using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Dao
{
    public abstract class BaseDao
    {
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType">Ten table can tro den</param>
        /// <param name="row">object muon them vao</param>
        public void insert(EntityType entityType, BaseRow row)
        {
            Database.Instance.insertTable(entityType, row);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entityType"></param>
        /// <param name="row"></param>
        public void update(EntityType entityType, BaseRow row)
        {
            Database.Instance.updateTable(entityType, row);
        }
        public void delete(EntityType entityType, BaseRow row)
        {
            Database.Instance.deleteTable(entityType, row.Id);
        }
        public List<BaseRow> findAll(EntityType entityType)
        {
            List<BaseRow> table = Database.Instance.selectTable(entityType);
            return table;
        }
        public BaseRow findById(EntityType entityType, int id)
        {
            BaseRow c = Database.Instance.getIEntityById(entityType, id);
            if (c == null)
            {
                return null;
            }
            return c;
        }
    }
}

