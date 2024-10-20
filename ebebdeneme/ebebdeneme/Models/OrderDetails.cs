using System;
using System.Collections.Generic;
using System.Text;

namespace ebebdeneme.Models
{
    public class OrderDetails
    {
        public string OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public int Id { get; set; }
        public string GiyimName { get; set; }
        public int Quentity { get; set; }
        public decimal Fiyat { get; set; }
    }
}
