namespace OOP_Quan
{
    internal class Product : BaseRow
    { 
        private int categoryId;
        public int CategoryId { get { return categoryId; } set { categoryId = value; } }

        public Product(int id, string name, int categotyId)
        {
            Id = id;
            Name = name;
            CategoryId = categotyId;
        }
    }
}
