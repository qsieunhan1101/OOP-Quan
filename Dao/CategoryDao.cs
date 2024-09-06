using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_Quan.Entity;
using OOP_Quan.Interface;

namespace OOP_Quan.Dao
{
    internal class CategoryDao : BaseDao, IDao<BaseRow>
    {
        public BaseRow findByName( string name)
        {
            BaseRow product = Database.Instance.getIEntityByName(EntityType.Category, name);
            return product;
        }

        public List<BaseRow> search(string name)
        {
            List<BaseRow> tableProduct = Database.Instance.selectTable(EntityType.Category);
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
