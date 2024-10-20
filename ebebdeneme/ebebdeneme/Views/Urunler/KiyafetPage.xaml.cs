using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
//"https://cdn.e-bebek.com/y.ebebek/ebebek-static/pp-preprod/e-logo.svg"
namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KiyafetPage : ContentPage
    {
        public KiyafetPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=35,
                    Name = "HelloBaby Bady",
                    Fiyat = 19,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EY/lGENHELUBDY5002BEY_1.jpg"
                },
                new Giyim
                {
                    Id=36,
                    Name = "CicCi Tulum",
                    Fiyat = 19,
                    Url ="https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000070898_1.jpg"
                },
                new Giyim
                {
                    Id=37,
                    Name = "HelloBaby Tişört",
                    Fiyat = 49,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/34/l20YHBLETST009-0034_1.jpg"
                },
                new Giyim
                {
                    Id=38,
                    Name = "HelloBaby Ceket",
                    Fiyat = 49,
                    Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000058856_1.jpg"
                },
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