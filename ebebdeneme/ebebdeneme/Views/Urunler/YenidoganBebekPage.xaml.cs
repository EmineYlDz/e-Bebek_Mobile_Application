using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Models;
using ebebdeneme.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class YenidoganBebekPage : ContentPage
    {
        public YenidoganBebekPage()
        {
            InitializeComponent(); 
            BindingContext = new YenidoganBebekViewModel();
            
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id= 42,
                    Name = "Penye Ağız Mendili 6'lı",
                    Fiyat = 17,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/21/lGENHBLUMND006-0021_1.jpg"
                },
                new Giyim
                {
                    Id=43,
                    Name = "Taşıtlı 3'lü Zıbın ",
                    Fiyat = 39,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/03/lGENHBLESET017-0003_1.jpg"
                },
                new Giyim
                {
                    Id=44,
                    Name = "Penguen 3'lü Zıbın",
                    Fiyat = 39,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/14/lGENHBLKSET014-0014_1.jpg"
                },
                new Giyim
                {
                    Id=45,
                    Name = " 2'li Omuz Örtüsü",
                    Fiyat = 14,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/38/smGENHBLKOMZ004-0038_1.jpg"
                },
                new Giyim
                {
                    Id=46,
                    Name = "Yıldız Hastane Çıkışı",
                    Fiyat = 54,
                    Url ="https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/1990000049767_1.jpg"
                }
            };
            Giyims.ItemsSource = giyims;

        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Giyim selectedItem = e.SelectedItem as Giyim;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            Giyim tappedItem = e.Item as Giyim;
        }
    }
}
