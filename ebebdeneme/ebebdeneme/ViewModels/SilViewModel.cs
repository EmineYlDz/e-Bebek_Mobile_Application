using DynamicData;
using ebebdeneme.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace ebebdeneme.ViewModels
{
    public class SilViewModel : ReactiveObject, IDisposable
    {
        public SilViewModel()
        {
            _sourceCache.AddOrUpdate(new List<Sil>()
            {
            new Sil ("HelloBaby Bady","19","0-25","https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EY/lGENHELUBDY5002BEY_1.jpg"),
            new Sil ("CicCi Tulum","19","0-25","https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000070898_1.jpg" ),
            new Sil ("HelloBaby Tişört"," 49", "25-50", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/34/l20YHBLETST009-0034_1.jpg" ),
            new Sil("HelloBaby Ceket","49", "25-50", "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000058856_1.jpg" ),

            new Sil("2'li Bebek Atlet"," 14","0-25", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/AV/lGENHELEALT6254MAV_1.jpg" ),
            new Sil( "2'li Penti","16", "0-25","https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/04/lGENHBLKKLT004-0004_1.jpg" ),
            new Sil("Kayıp Timsah Atlet",  "12", "0-25", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/51/l20YFPREALT014-0051_1.jpg" ),
            new Sil("Tatlı Kiraz Atlet",  "13", "0-25",  "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/l20YFPRKALT051-0022_1.jpg" ),
            new Sil("Nemo Atlet",  "17",  "0-25","https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/07/l20YDISEALT058-0007_1.jpg" ),

            new Sil("Dinazor Çocuk Çantası", " 49",  "25-50","https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065189_1.jpg" ),
            new Sil("Fil Figürlü Çanta",  "54", "50-100","https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/lGENFPRUCNT003-0032_1.jpg" ),
            new Sil("Panda Figürlü Çanta"," 69",  "50-100", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/lGENFPRUCNT004-0022_1.jpg" ),
            new Sil("Çocuk Valizi Beyaz",  "199", "100-500", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/27/lOXO-8427_1.jpg" ),
            new Sil("Kedi Bebek Sırt Çantası",  "69",  "50-100",  "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065799_1.jpg" ),

            new Sil("Penye Ağız Mendili 6'lı", "16",  "0-25",  "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/21/lGENHBLUMND006-0021_1.jpg" ),
            new Sil("Taşıtlı 3'lü Zıbın ",  "39",  "25-50",  "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/03/lGENHBLESET017-0003_1.jpg" ),
            new Sil("Penguen 3'lü Zıbın", "39", "25-50", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/14/lGENHBLKSET014-0014_1.jpg" ),
            new Sil("İkili Omuz Örtüsü",  "14", "0-25",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/38/smGENHBLKOMZ004-0038_1.jpg" ),
            new Sil("Yıldız Hastane Çıkışı", "54",  "50-100",  "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/1990000049767_1.jpg" ),

            new Sil("HelloBaby Ayakkabı", "49",  "25-50", "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065462_1.jpg" ),
            new Sil("CicCi Çorap",  "9", "0-25", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EM/lGENHELKCRP6207PEM_1.jpg" ),
            new Sil("First Step Erkek Bebek"," 29", "25-50", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/28/l20YFSPKAYK005-0028_1.jpg" ),
            new Sil("First Step Kız Bebek",  "29",  "25-50",   "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/l20YFSPKAYK007-0032_1.jpg" ),
            new Sil("Kiraz Patik", "12", "0-25", "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000072664_1.jpg" ),

            new Sil( "Baby Memory Prints",  "64", "50-100", "https://cdn.e-bebek.com/www.ebebek/i/p/200/02/smBMP-081002_1.jpg" ),
            new Sil("Mycey",  "29",  "25-50",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/04/smMYC-24000004_1.jpg" ),
            new Sil("Nazarık Bebek Ayak İzi",  "39",  "25-50",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/20/smBMP-14620_1.jpg" ),

            new Sil("BabyPlus Beşik",  "629",  "500-2000", "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/RG/lBYP-TBP01ORG_1.jpg" ),
            new Sil( "Tahterevali", "1419", "500-2000",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/EY/smTHT-TS-01-BEY_1.jpg" ),
            new Sil( "Bebek Hamağı",  "179", "100-500", "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/8697454052307_1.jpg" ),

            new Sil("Dalin 900ml", "19",  "0-25", "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8690605060992_1.jpg" ),
            new Sil("Bebek Banyo Süngeri", "9", "0-25",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/45/smBYP-5345_1.jpg" ),
            new Sil("Banyo Filesi", "78",  "50-100",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/90/smSEV-690_1.jpg" ),

            new Sil("Burun Aspiratörü",  "14",  "0-25", "https://cdn.e-bebek.com/www.ebebek/i/p/200/98/smBYP-199098_1.jpg" ),
            new Sil("Bebek Pudra Kokusu", "26",  "25-50",  "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/2558000170080_1.jpg" ),
            new Sil("Bebek Tarağı", "24",  "25-50", "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680075434546_1.jpg" ),

            new Sil( "Eğitici Top", "10", "0-25",  "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8682250032523_1.jpg" ),
            new Sil( "Bowling Seti",  "19", "0-25",  "https://cdn.e-bebek.com/www.ebebek/i/p/200/77/smBYT-1277_1.jpg" ),
            new Sil( "Çizim Tableti", "39", "25-50",  "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8698540308643_1.jpg" ),

            new Sil( "Yunus Çıngırak"," 9", "0-25", "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680084578606_1.jpg" ),
            new Sil( "Bebek Puzzle", "44", "25-50", "https://cdn.e-bebek.com/www.ebebek/i/p/200/3B/smSTT-1005B3B_1.jpg" ),
            new Sil( "Mantar Oyun Halısı", "110", "100-500", "https://cdn.e-bebek.com/www.ebebek/i/p/200/39/smBRL-HE0639_1.jpg" ),

            new Sil("Bebek Arabası", "1119", "500-2000","https://cdn.e-bebek.com/www.ebebek/i/p/200/10/smJOI-S1112DJURB010_1.jpg" ),
            new Sil( "Joie Bebek Arabası",  "1401", "500-2000","https://cdn.e-bebek.com/www.ebebek/i/p/200/97/smBYP-LOU-0197_1.jpg" ),

            new Sil( "Oyuncaklı Anakucağı",  "139", "100-500","https://cdn.e-bebek.com/www.ebebek/i/p/200/97/smBYP-LOU-0197_1.jpg" ),
            new Sil( "Lucca Ana Kucağı","99", "50-100", "https://cdn.e-bebek.com/www.ebebek/i/p/200/53/smBYP-ACT-0653_1.jpg" ),
            });

            //Search logic
            Func<Sil, bool> silFilter(string text) => sil =>
            {
                return string.IsNullOrEmpty(text) || sil.Name.ToLower().Contains(text.ToLower()) || sil.Fiyat.ToLower().Contains(text.ToLower()) || sil.Url.ToLower().Contains(text.ToLower());
            };

            var filterPredicate = this.WhenAnyValue(x => x.SearchText)
                                      .Throttle(TimeSpan.FromMilliseconds(250), RxApp.TaskpoolScheduler)
                                      .DistinctUntilChanged()
                                      .Select(silFilter);

            //Filter logic
            Func<Sil, bool> aralikFilter(string aralik) => sil =>
            {
                return aralik == "All" || aralik == sil.Aralik;
            };

            var aralikPredicate = this.WhenAnyValue(x => x.SelectedAralikFilter)
                                       .Select(aralikFilter);
            _cleanUp = _sourceCache.Connect()
            .RefCount()
            .Filter(aralikPredicate)
            .Filter(filterPredicate)
            .Bind(out _sils)
            .DisposeMany()
            .Subscribe();

            SelectedAralikFilter = "All";

            AddCommand = ReactiveCommand.CreateFromTask(async () => await ExecuteAdd());
            DeleteCommand = ReactiveCommand.Create<Sil>(ExecuteRemove);
        }
        private void ExecuteRemove(Sil sil)
        {
            _sourceCache.Edit((update) =>
            {
                update.Remove(sil);
            });
        }

        private async Task ExecuteAdd()
        {
            var name = await App.Current.MainPage.DisplayPromptAsync("Insert Name", "");
            _sourceCache.Edit((update) =>
            {
                update.AddOrUpdate(new Sil(name, "Casual", "Fast Food", "US"));
            });
        }
        public void Dispose()
        {
            _cleanUp.Dispose();
        }

        public ReadOnlyObservableCollection<Sil> Sils => _sils;
        public string SearchText
        {
            get => _searchText;
            set => this.RaiseAndSetIfChanged(ref _searchText, value);
        }

        public string SelectedAralikFilter
        {
            get => _selectedAralikFilter;
            set => this.RaiseAndSetIfChanged(ref _selectedAralikFilter, value);
        }
        public ReactiveCommand<Unit, Unit> AddCommand { get; set; }
        public ReactiveCommand<Sil, Unit> DeleteCommand { get; }
        private SourceCache<Sil, string> _sourceCache = new SourceCache<Sil, string>(x => x.Id);
        private readonly ReadOnlyObservableCollection<Sil> _sils;
        private string _searchText;
        private string _selectedAralikFilter;
        private readonly IDisposable _cleanUp;
    }
}