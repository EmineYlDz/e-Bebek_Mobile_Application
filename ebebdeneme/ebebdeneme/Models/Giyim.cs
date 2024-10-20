using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ebebdeneme.Models
{
    public class Giyim
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public decimal Fiyat { get; set; }
        public int CategoryID { get; set; }
       
    }
}
