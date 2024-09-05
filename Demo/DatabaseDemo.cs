using OOP_Quan.Dao;
using OOP_Quan.Entity;
using System;
using System.Collections.Generic;

namespace OOP_Quan.Demo
{

    internal class DatabaseDemo
    {

        static void Main(string[] args)
        {
            Database databaseTest = new Database();


            Console.WriteLine("Tao gia tri Database ");
            initDatabase(databaseTest);


            selectTableTest(EntityType.Product, databaseTest);
            updateTableTest(EntityType.Product, databaseTest, new Product(3, "new prpo", 136));

            deleteTableTest(EntityType.Product, databaseTest, 2);

            //truncateTableTest(EntityType.Product, databaseTest);

            updateTableByIdTest(EntityType.Product,databaseTest, 3, new Product(100, "new--------", 1000));
        }

        static void insertTableTest(IEntity p, Database database, EntityType entityType)
        {
            database.insertTable(entityType, p);

            printTableTest(p);
        }
        static void selectTableTest(EntityType entityType, Database database)
        {
            List<IEntity> listEntity = database.selectTable(entityType);
            Console.WriteLine($"\nSElectTable {entityType.ToString()}");
            if (listEntity.Count <= 0)
            {
                Console.WriteLine("Table is Empty");
                return;
            }
            for (int i = 0; i < listEntity.Count - 1; i++)
            {
                printTableTest((IEntity)listEntity[i]);
            }
        }
        static void updateTableTest(EntityType entityType, Database database, IEntity row)
        {
            database.updateTable(entityType, row);
            selectTableTest(entityType, database);
        }
        static void deleteTableTest(EntityType entityType, Database database, int id)
        {
            database.deleteTable(entityType, id);
            Console.Write($"------deleteTableTest");

            selectTableTest(entityType, database);
        }
        static void truncateTableTest(EntityType entityType, Database database)
        {
            database.truncateTable(entityType);
            Console.WriteLine($"\nXoa thanh cong table");

            selectTableTest(entityType, database);

        }
        static void initDatabase(Database database)
        {
            Console.WriteLine("Product Table");
            for (int i = 0; i < 10; i++)
            {
                Product p = new Product(i, $"Produc {i}", i + 1);
                insertTableTest(p, database, EntityType.Product);
            }
            Console.WriteLine("Category Table");

            for (int i = 0; i < 10; i++)
            {
                Category c = new Category(i, $"Category {i}");
                insertTableTest(c, database, EntityType.Category);
            }

            Console.WriteLine("Accessotion Table");

            for (int i = 0; i < 10; i++)
            {
                Accessotion a = new Accessotion(i, $"Produc {i}");
                insertTableTest(a, database, EntityType.Accessory);
            }


        }

        static void updateTableByIdTest(EntityType entityType, Database database, int id, IEntity row)
        {
            database.updateTableById(entityType, id, row);
            Console.WriteLine($"\nCap nhat by ID thanh cong");
            selectTableTest(entityType, database);

        }








        static void printTableTest(IEntity row)
        {
            Console.Write("Id:" + row.Id);
            Console.Write(" Name:" + row.Name);
            Console.Write("   ");
            Console.Write("\n");
        }
    }
}
