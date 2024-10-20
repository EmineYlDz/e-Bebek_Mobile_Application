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
    public class AddGiyimData
    {
        FirebaseClient Client;
        public List<Giyim> IList { get; set; }
        public AddGiyimData()
        {
            IList = new List<Giyim>();
            IList.Add(new Giyim { Id = 35, CategoryID = 1, Name = "HelloBaby Bady", Fiyat = 19, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EY/lGENHELUBDY5002BEY_1.jpg" });
            IList.Add(new Giyim { Id = 36, CategoryID = 1, Name = "CicCi Tulum", Fiyat = 19, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000070898_1.jpg" });
            IList.Add(new Giyim { Id = 37, CategoryID = 1, Name = "HelloBaby Tişört", Fiyat = 49, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/34/l20YHBLETST009-0034_1.jpg" });
            IList.Add(new Giyim { Id = 38, CategoryID = 1, Name = "HelloBaby Ceket", Fiyat = 49, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000058856_1.jpg" });

            IList.Add(new Giyim { Id = 30, CategoryID = 11, Name = "2'li Bebek Atlet", Fiyat = 14, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/AV/lGENHELEALT6254MAV_1.jpg" });
            IList.Add(new Giyim { Id = 31, CategoryID = 11, Name = "2'li Penti", Fiyat = 16, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/04/lGENHBLKKLT004-0004_1.jpg" });
            IList.Add(new Giyim { Id = 32, CategoryID = 11, Name = "Kayıp Timsah Atlet", Fiyat = 12, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/51/l20YFPREALT014-0051_1.jpg" });
            IList.Add(new Giyim { Id = 33, CategoryID = 11, Name = "Tatlı Kiraz Atlet", Fiyat = 13, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/l20YFPRKALT051-0022_1.jpg" });
            IList.Add(new Giyim { Id = 34, CategoryID = 11, Name = "Nemo Atlet", Fiyat = 17, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/07/l20YDISEALT058-0007_1.jpg" });

            IList.Add(new Giyim { Id = 16, CategoryID = 12, Name = "Dinazor Çocuk Çantası", Fiyat = 49, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065189_1.jpg" });
            IList.Add(new Giyim { Id = 17, CategoryID = 12, Name = "Fil Figürlü Çanta", Fiyat = 54, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/lGENFPRUCNT003-0032_1.jpg" });
            IList.Add(new Giyim { Id = 18, CategoryID = 12, Name = "Panda Figürlü Çanta", Fiyat = 69, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/lGENFPRUCNT004-0022_1.jpg" });
            IList.Add(new Giyim { Id = 19, CategoryID = 12, Name = "Çocuk Valizi Beyaz", Fiyat = 199, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/27/lOXO-8427_1.jpg" });
            IList.Add(new Giyim { Id = 20, CategoryID = 12, Name = "Kedi Bebek Sırt Çantası", Fiyat = 69, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065799_1.jpg" });

            IList.Add(new Giyim { Id = 42, CategoryID = 13, Name = "Penye Ağız Mendili 6'lı", Fiyat = 16, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/21/lGENHBLUMND006-0021_1.jpg" });
            IList.Add(new Giyim { Id = 43, CategoryID = 13, Name = "Taşıtlı 3'lü Zıbın ", Fiyat = 39, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/03/lGENHBLESET017-0003_1.jpg" });
            IList.Add(new Giyim { Id = 44, CategoryID = 13, Name = "Penguen 3'lü Zıbın", Fiyat = 39, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/14/lGENHBLKSET014-0014_1.jpg" });
            IList.Add(new Giyim { Id = 45, CategoryID = 13, Name = "İkili Omuz Örtüsü", Fiyat = 14, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/38/smGENHBLKOMZ004-0038_1.jpg" });
            IList.Add(new Giyim { Id = 46, CategoryID = 13, Name = "Yıldız Hastane Çıkışı", Fiyat = 54, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/1990000049767_1.jpg" });

            IList.Add(new Giyim { Id = 3, CategoryID = 2, Name = "HelloBaby Ayakkabı", Fiyat = 49, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065462_1.jpg" });
            IList.Add(new Giyim { Id = 4, CategoryID = 2, Name = "CicCi Çorap", Fiyat = 9, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EM/lGENHELKCRP6207PEM_1.jpg" });
            IList.Add(new Giyim { Id = 5, CategoryID = 2, Name = "First Step Erkek Bebek", Fiyat = 29, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/28/l20YFSPKAYK005-0028_1.jpg" });
            IList.Add(new Giyim { Id = 6, CategoryID = 2, Name = "First Step Kız Bebek", Fiyat = 29, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/l20YFSPKAYK007-0032_1.jpg" });
            IList.Add(new Giyim { Id = 7, CategoryID = 2, Name = "Kiraz Patik", Fiyat = 12, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000072664_1.jpg" });

            IList.Add(new Giyim { Id = 21, CategoryID = 4, Name = "Baby Memory Prints", Fiyat = 64, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/02/smBMP-081002_1.jpg" });
            IList.Add(new Giyim { Id = 22, CategoryID = 4, Name = "Mycey", Fiyat = 29, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/04/smMYC-24000004_1.jpg" });
            IList.Add(new Giyim { Id = 23, CategoryID = 4, Name = "Nazarık Bebek Ayak İzi", Fiyat = 39, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/20/smBMP-14620_1.jpg" });

            IList.Add(new Giyim { Id = 39, CategoryID = 3, Name = "BabyPlus Beşik", Fiyat = 629, Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/RG/lBYP-TBP01ORG_1.jpg" });
            IList.Add(new Giyim { Id = 40, CategoryID = 3, Name = "Tahterevali", Fiyat = 1419, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/EY/smTHT-TS-01-BEY_1.jpg" });
            IList.Add(new Giyim { Id = 41, CategoryID = 3, Name = "Bebek Hamağı", Fiyat = 179, Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/8697454052307_1.jpg" });

            IList.Add(new Giyim { Id = 13, CategoryID = 5, Name = "Dalin 900ml", Fiyat = 19, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8690605060992_1.jpg" });
            IList.Add(new Giyim { Id = 14, CategoryID = 5, Name = "Bebek Banyo Süngeri", Fiyat = 9, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/45/smBYP-5345_1.jpg" });
            IList.Add(new Giyim { Id = 15, CategoryID = 5, Name = "Banyo Filesi", Fiyat = 78, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/90/smSEV-690_1.jpg" });

            IList.Add(new Giyim { Id = 10, CategoryID = 6, Name = "Burun Aspiratörü", Fiyat = 14, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/98/smBYP-199098_1.jpg" });
            IList.Add(new Giyim { Id = 11, CategoryID = 6, Name = "Bebek Pudra Kokusu", Fiyat = 26, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/2558000170080_1.jpg" });
            IList.Add(new Giyim { Id = 12, CategoryID = 6, Name = "Bebek Tarağı", Fiyat = 24, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680075434546_1.jpg" });

            IList.Add(new Giyim { Id = 27, CategoryID = 7, Name = "Eğitici Top", Fiyat = 10, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8682250032523_1.jpg" });
            IList.Add(new Giyim { Id = 28, CategoryID = 7, Name = "Bowling Seti", Fiyat = 19, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/77/smBYT-1277_1.jpg" });
            IList.Add(new Giyim { Id = 29, CategoryID = 7, Name = "Çizim Tableti", Fiyat = 39, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8698540308643_1.jpg" });

            IList.Add(new Giyim { Id = 24, CategoryID = 8, Name = "Yunus Çıngırak", Fiyat = 9, Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680084578606_1.jpg" });
            IList.Add(new Giyim { Id = 25, CategoryID = 8, Name = "Bebek Puzzle", Fiyat = 44, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/3B/smSTT-1005B3B_1.jpg" });
            IList.Add(new Giyim { Id = 26, CategoryID = 8, Name = "Mantar Oyun Halısı", Fiyat = 110, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/39/smBRL-HE0639_1.jpg" });

            IList.Add(new Giyim { Id = 8, CategoryID = 9, Name = "Bebek Arabası", Fiyat = 1119, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/10/smJOI-S1112DJURB010_1.jpg" });
            IList.Add(new Giyim { Id = 9, CategoryID = 9, Name = "Joie Bebek Arabası", Fiyat = 1401, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/97/smBYP-LOU-0197_1.jpg" });

            IList.Add(new Giyim { Id = 1, CategoryID = 10, Name = "Oyuncaklı Anakucağı", Fiyat = 139, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/97/smBYP-LOU-0197_1.jpg" });
            IList.Add(new Giyim { Id = 2, CategoryID = 10, Name = "Lucca Ana Kucağı", Fiyat = 99, Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/53/smBYP-ACT-0653_1.jpg" });

            Client = new FirebaseClient("https://ebebek-c02cb-default-rtdb.firebaseio.com/");
        }
        public async Task AddGiyimAsync()
        {
            try
            {
                foreach (var giyim in IList)
                {
                    await Client.Child("IList").PostAsync(new Giyim()
                    {
                        CategoryID = giyim.CategoryID,
                        Id = giyim.Id,
                        Name = giyim.Name,
                        Fiyat = giyim.Fiyat,
                        Url = giyim.Url
                    });
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "OK");
            }
        }
    }
}
