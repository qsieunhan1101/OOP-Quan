﻿namespace OOP_Quan.Entity
{
    internal class Accessotion : IEntity
    {
        private int id;
        private string name;

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }


    }
}
