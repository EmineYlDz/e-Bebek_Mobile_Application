using ebebdeneme.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ebebdeneme.Helpers
{
    public class AddCategoryData 
    {
        public List<Category> Categories { get; set; }
        FirebaseClient Client;
        public AddCategoryData()
        {
            Categories = new List<Category>()
            {
                new Category()
                {
                    CategoryID =1,
                    CategoryName ="KIYAFET",
                    ImageUrl ="kiyafet.png"
                },
                new Category()
                {
                    CategoryID =2,
                    CategoryName ="AYAKKABI",
                    ImageUrl ="ayakkabi.png"
                },
                new Category()
                {
                    CategoryID =3,
                    CategoryName ="BEŞİK",
                    ImageUrl ="bebekodasi.png"
                },
                new Category()
                {
                    CategoryID =4,
                    CategoryName ="BEBEK ODASI AKSESUARLARI",
                    ImageUrl ="aksesuar.png"
                },
                new Category()
                {
                    CategoryID =5,
                    CategoryName ="BEBEK BANYO ÜRÜNLERİ",
                    ImageUrl ="banyo1.png"
                },
                new Category()
                {
                    CategoryID =6,
                    CategoryName ="BEBEK BAKIM ÜRÜNLERİ",
                    ImageUrl ="bakim.png"
                },
                new Category()
                {
                    CategoryID =7,
                    CategoryName ="EĞİTİCİ OYUNCAKLAR",
                    ImageUrl ="eoyuncak.png"
                },
                new Category()
                {
                    CategoryID =8,
                    CategoryName ="BEBEK OYUNCAKLARI",
                    ImageUrl ="oyuncak.png"
                },
                new Category()
                {
                    CategoryID =9,
                    CategoryName ="BEBEK ARABASI",
                    ImageUrl ="sepetimm.png"
                },
                new Category()
                {
                    CategoryID =10,
                    CategoryName ="ANA KUCAĞI",
                    ImageUrl ="anakucagi.png"
                },
                new Category()
                {
                    CategoryID =11,
                    CategoryName ="İÇ GİYİM",
                    ImageUrl ="icgiyim.png"
                },
                new Category()
                {
                    CategoryID =12,
                    CategoryName ="BEBEK ÇANTASI",
                    ImageUrl ="bebekcantasi.png"
                },
                new Category()
                {
                    CategoryID =13,
                    CategoryName ="YENİ DOĞAN",
                    ImageUrl ="yenidogan.png"
                },

            };
            Client = new FirebaseClient("https://ebebek-c02cb-default-rtdb.firebaseio.com/");
        }

        public async Task AddCategoriesAsync()
        {
            try
            {
                foreach (var category in Categories)
                {
                    await Client.Child("Categories").PostAsync(new Category()
                    {
                        CategoryID = category.CategoryID,
                        CategoryName = category.CategoryName,
                        ImageUrl = category.ImageUrl
                    });
                }
            }
            catch(Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "OK");
            }
        }
    }
}
