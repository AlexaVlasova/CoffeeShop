using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShop.Models
{
    [Table("Order")]
    class Order
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public User UserId { get; set; }

        

    }
}
