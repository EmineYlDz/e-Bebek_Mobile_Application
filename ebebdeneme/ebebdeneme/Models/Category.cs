using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace ebebdeneme.Models
{
    public class Category
    {
        
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        //public string CategoryPoster { get; set; }
        public string ImageUrl { get; set; }
        /*public override string ToString()
        {
            return string.Format("Category : CategoryID={0},CategoryName = {1},ImageUrl = {2}", CategoryID, CategoryName, ImageUrl);
        }*/
    }
}
