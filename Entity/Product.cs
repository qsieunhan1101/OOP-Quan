using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Quan
{
    internal class Product : IEntity
    {
        
        public int id;
        public string name;
        public int categoryId;

        public Product() { }
        public Product(int id, int categoryId)
        {
            this.id = id;
            this.categoryId = categoryId;
            name = "product";
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
    }
}
