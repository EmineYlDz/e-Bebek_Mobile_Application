using ebebdeneme.Models;
using Firebase.Database;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ebebdeneme.Services
{
    public class GiyimService
    {
        FirebaseClient Client;
        public GiyimService()
        {
            Client = new FirebaseClient("https://ebebek-c02cb-default-rtdb.firebaseio.com/");
        }
        public async Task<List<Giyim>> GetGiyimAsync()
        {
            var giyims = (await Client.Child("IList")
              .OnceAsync<Giyim>())

              .Select(g => new Giyim
              {
                  Id = g.Object.Id,
                  CategoryID = g.Object.CategoryID,
                  Name = g.Object.Name,
                  Fiyat = g.Object.Fiyat,
                  Url = g.Object.Url

              }).ToList();

            return giyims;
        }
        
        public async Task<ObservableCollection<Giyim>> GetGiyimsByCategoryAsync(int categoryID)
        {
            var giyimsByCategory = new ObservableCollection<Giyim>();
            var items = (await GetGiyimAsync()).Where(p => p.CategoryID == categoryID).ToList();
            foreach (var item in items)
            {
                giyimsByCategory.Add(item);
            }
            return giyimsByCategory;
        }
        public async Task<ObservableCollection<Giyim>> GetLatesGiyimsAsync()
        {
            var latesGiyims = new ObservableCollection<Giyim>();
            var items = (await GetGiyimAsync()).OrderByDescending(g => g.Id ).Take(3);
            foreach (var item in items)
            {
                latesGiyims.Add(item);
            }
            return latesGiyims;
        }

    }
}
