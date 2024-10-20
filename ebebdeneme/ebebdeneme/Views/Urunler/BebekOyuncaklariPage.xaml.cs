using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BebekOyuncaklariPage : ContentPage
    {
        public BebekOyuncaklariPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=24,
                    Name = "Yunus Çıngırak",
                    Fiyat = 9,
                    Url ="https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680084578606_1.jpg"
                },
                new Giyim
                {
                    Id=25,
                    Name = "Bebek Puzzle",
                    Fiyat = 44,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/3B/smSTT-1005B3B_1.jpg"
                },
                new Giyim
                {
                    Id=26,
                    Name = "Mantar Oyun Halısı",
                    Fiyat = 110,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/39/smBRL-HE0639_1.jpg"
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