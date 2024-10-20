using SQLite;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ebebdeneme.Models
{
    //[Table("CartItem")]
    public class CartItem
    {
        [AutoIncrement,PrimaryKey]

        public int CartItemId { get; set; }
        public int Id { get; set; }
        public string GiyimName { get; set; }
        public decimal Fiyat { get; set; }
        public int Quantity { get; set; }

    }
}
