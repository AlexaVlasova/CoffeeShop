using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace CoffeeShop.Models
{
    [Table("Items")]
    public class CoffeeItem
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Category { get; set; }


    }
}
