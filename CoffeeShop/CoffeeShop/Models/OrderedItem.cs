using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Models
{
    [Table("OrderedItem")]
    class OrderedItem
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }
      
        public Order OrderId { get; set; }

        public CoffeeItem Item { get; set; }
        public int Count { get; set; }

    }
}
