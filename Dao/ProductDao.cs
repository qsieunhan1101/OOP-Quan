using OOP_Quan.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan.Dao
{
    internal class ProductDao : BaseDao
    {
        public BaseRow findByName(EntityType entityType ,string name)
        {
            BaseRow row = Database.Instance.getIEntityByName(entityType,name);
            if (row == null)
            {
                Console.WriteLine($"Can not find Row have name {name}");
                return null;
            }

            return row;
        }
    }
}
