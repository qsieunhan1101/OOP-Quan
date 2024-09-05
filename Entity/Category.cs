namespace OOP_Quan.Entity
{
    internal class Category : IEntity
    {
        private int id;
        private string name;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }

        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
