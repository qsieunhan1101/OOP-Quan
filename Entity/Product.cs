namespace OOP_Quan
{
    internal class Product : IEntity
    {

        private int id;
        private string name;
        private int categoryId;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int CategoryId { get { return categoryId; } set { categoryId = value; } }

        public Product(int id, string name, int categotuId)
        {
            Id = id;
            Name = name;
            CategoryId = categotuId;
        }
    }
}
