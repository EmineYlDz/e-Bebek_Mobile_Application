using ebebdeneme.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database.Query;
using System.Linq;

namespace ebebdeneme.Services
{
   public class CategoryDataService
    {
        FirebaseClient Client;

        public CategoryDataService()
        {
            Client = new FirebaseClient("https://ebebek-c02cb-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Category>> GetCategoriesAsync()
        {
            var categories = (await Client.Child("Categories")
              .OnceAsync<Category>())

              .Select(c => new Category
              {
                  CategoryID = c.Object.CategoryID,
                  CategoryName = c.Object.CategoryName,
                  ImageUrl = c.Object.ImageUrl

              }).ToList();

            return categories;
        }
    }
}
