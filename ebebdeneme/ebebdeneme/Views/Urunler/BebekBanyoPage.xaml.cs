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
    public partial class BebekBanyoPage : ContentPage
    {
        public BebekBanyoPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=13,
                    Name = "Dalin 900ml",
                    Fiyat = 19,
                    Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8690605060992_1.jpg"
                },
                new Giyim
                {
                    Id=14,
                    Name = "Bebek Banyo Süngeri",
                    Fiyat = 9,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/45/smBYP-5345_1.jpg"
                },
                new Giyim
                {
                    Id=15,
                    Name = "Banyo Filesi",
                    Fiyat = 78,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/90/smSEV-690_1.jpg"
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