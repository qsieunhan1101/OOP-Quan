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
        /// Yeu cau Database them mot object vao bang tuong ung
        /// </summary>
        /// <param name="entityType">Ten table can tro den</param>
        /// <param name="row">object muon them vao</param>
        public void insert(EntityType entityType, BaseRow row)
        {
            Database.Instance.insertTable(entityType, row);
        }
        /// <summary>
        /// Yeu cau cap nhat lai bang theo mot doi tuong truyen vao
        /// </summary>
        /// <param name="entityType">Ten bang can tro den</param>
        /// <param name="row">object muon cap nhat</param>
        public void update(EntityType entityType, BaseRow row)
        {
            Database.Instance.updateTable(entityType, row);
        }
        /// <summary>
        /// Yeu cau Database xoa mot phan tu truyen vao
        /// </summary>
        /// <param name="entityType">Ten bang can tro den</param>
        /// <param name="row">object can xoa</param>
        public void delete(EntityType entityType, BaseRow row)
        {
            Database.Instance.deleteTable(entityType, row.Id);
        }
        /// <summary>
        /// Yeu cau Database tim kiem toan bo theo ten bang
        /// </summary>
        /// <param name="entityType">Ten bang can tro den</param>
        /// <returns></returns>
        public List<BaseRow> findAll(EntityType entityType)
        {
            List<BaseRow> table = Database.Instance.selectTable(entityType);
            return table;
        }
        /// <summary>
        /// Yeu cau tim kiem theo Id
        /// </summary>
        /// <param name="entityType">Ten bang can truy cap</param>
        /// <param name="id">Id can tim</param>
        /// <returns></returns>
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

