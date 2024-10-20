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
    public partial class YatakPage : ContentPage
    {
        public YatakPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=39,
                    Name = "BabyPlus Beşik",
                    Fiyat = 629,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/RG/lBYP-TBP01ORG_1.jpg"
                },
                new Giyim
                {
                    Id=40,
                    Name = "Tahterevali",
                    Fiyat = 1419,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/EY/smTHT-TS-01-BEY_1.jpg"
                },
                 new Giyim
                {
                    Id=41,
                    Name = "Bebek Hamağı",
                    Fiyat = 179,
                    Url ="https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/8697454052307_1.jpg"
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