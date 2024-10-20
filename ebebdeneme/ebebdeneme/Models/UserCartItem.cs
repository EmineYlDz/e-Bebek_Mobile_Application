using System;
using System.Collections.Generic;
using System.Text;

namespace ebebdeneme.Models
{
    public class UserCartItem
    {
        public int CartItemId { get; set; }
        public int Id { get; set; }
        public string GiyimName { get; set; }
        public decimal Fiyat { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }
    }
}
