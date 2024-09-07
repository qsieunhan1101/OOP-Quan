using OOP_Quan.Entity;
using OOP_Quan.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Dao
{
    internal class AccessoryDao : BaseDao, IDao<BaseRow>
    {
        /// <summary>
        /// Yeu cau Database tra object muon tìm trong bang Accesssory
        /// </summary>
        /// <param name="name">ten cua doi tuong trong bang</param>
        /// <returns></returns>
        public BaseRow findByName(string name)
        {
            BaseRow product = Database.Instance.getIEntityByName(EntityType.Accessory, name);
            return product;
        }
        /// <summary>
        /// Yeu cau Database tra ve mot List object co ten tuong ung trong bang Accesssory
        /// </summary>
        /// <param name="name">Ten cua doi tuong trong báng</param>
        /// <returns></returns>
        public List<BaseRow> search(string name)
        {
            List<BaseRow> tableProduct = Database.Instance.selectTable(EntityType.Accessory);
            List<BaseRow> listTarget = new List<BaseRow>();
            for (int i = 0; i < tableProduct.Count; i++)
            {
                if (tableProduct[i].Name.Contains(name))
                {
                    listTarget.Add(tableProduct[i]);
                }
            }

            return listTarget;
        }

    }
}
