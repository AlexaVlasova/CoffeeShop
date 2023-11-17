using CoffeeShop.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CoffeeShop.Data
{
    public class CoffeeShopRepository
    {
        SQLiteConnection database;
        public CoffeeShopRepository(string databasePath)
        {
            database = new SQLiteConnection(databasePath);
            database.CreateTable<CoffeeItem>();
        }
        public IEnumerable<CoffeeItem> GetItems()
        {
            return database.Table<CoffeeItem>().ToList();
        }
        public IEnumerable<CoffeeItem> GetItemsByCategory(string category)
        {
            return database.Table<CoffeeItem>().Where(item => item.Category.Equals(category)).ToList();
        }
        public CoffeeItem GetItem(int id)
        {
            return database.Get<CoffeeItem>(id);
        }
        public int DeleteItem(int id)
        {
            return database.Delete<CoffeeItem>(id);
        }
        public int SaveItem(CoffeeItem item)
        {
            if (item.Id != 0)
            {
                database.Update(item);
                return item.Id;
            }
            else
            {
                return database.Insert(item);
            }
        }
    }
}
