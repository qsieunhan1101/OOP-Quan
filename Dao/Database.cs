using OOP_Quan.Entity;
using System;
using System.Collections.Generic;

namespace OOP_Quan.Dao
{
    internal class Database
    {

        private List<Product> productTable = new List<Product>();
        private List<Category> categotyTable = new List<Category>();
        private List<Accessotion> accessoryTable = new List<Accessotion>();
        private Database instants;

        public void insertTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    productTable.Add((Product)row);
                    break;
                case "category":
                    categotyTable.Add((Category)row);
                    break;
                case "accessory":
                    accessoryTable.Add((Accessotion)row);
                    break;
            }
        }
        public List<IEntity> selectTable(string name, object where)
        {
            List<IEntity> entities = new List<IEntity>();
            switch (name)
            {
                case "product":

                    foreach (IEntity entity in productTable)
                    {
                        entities.Add(entity);
                    }
                    Console.WriteLine("da lay bang product");
                    break;
                case "category":
                    foreach (IEntity entity in categotyTable)
                    {
                        entities.Add(entity);

                    }
                    Console.WriteLine("da lay bang category");
                    break;
                case "accessory":
                    foreach (IEntity entity in accessoryTable)
                    {
                        entities.Add(entity);

                    }
                    Console.WriteLine("da lay bang accessory");
                    break;
            }
            return entities;
        }
        public void updateTable(string name, object row)
        {
            switch (name)
            {
                case "product":
                    Product tableProduct = row as Product;
                    for (int i = 0; i < productTable.Count - 1; i++)
                    {
                        if (productTable[i].id == tableProduct.id)
                        {
                            productTable[i] = tableProduct;
                        }
                    }
                    break;
                case "category":
                    Category tableCategory = row as Category;
                    for (int i = 0; i < categotyTable.Count - 1; i++)
                    {
                        if (categotyTable[i].id == tableCategory.id)
                        {
                            categotyTable[i] = tableCategory;
                        }
                    }
                    break;
                case "accessory":

                    Accessotion tableAccess = row as Accessotion;
                    for (int i = 0; i < productTable.Count - 1; i++)
                    {
                        if (accessoryTable[i].id == tableAccess.id)
                        {
                            accessoryTable[i] = tableAccess;
                        }
                    }
                    break;
            }
        }
        public void deleteTable(string name, object row)
        {
            switch (name)
            {
                case "product":

                    Product tableProduct = row as Product;
                    for (int i = 0; i < productTable.Count - 1; i++)
                    {
                        if (productTable[i].id == tableProduct.id)
                        {
                            productTable.RemoveAt(i);
                        }
                    }
                    break;
                case "category":
                    Category tableCategory = row as Category;
                    for (int i = 0; i < categotyTable.Count - 1; i++)
                    {
                        if (categotyTable[i].id == tableCategory.id)
                        {
                            categotyTable.RemoveAt(i);
                        }
                    }
                    break;
                case "accessory":
                    Accessotion tableAccess = row as Accessotion;
                    for (int i = 0; i < productTable.Count - 1; i++)
                    {
                        if (accessoryTable[i].id == tableAccess.id)
                        {
                            accessoryTable.RemoveAt(i);
                        }
                    }
                    break;
            }

        }
        public void truncateTable(string name)
        {
            switch (name)
            {
                case "product":
                    productTable.Clear();
                    break;
                case "category":
                    categotyTable.Clear();
                    break;
                case "accessory":
                    accessoryTable.Clear();
                    break;
            }
        }
    }
}
