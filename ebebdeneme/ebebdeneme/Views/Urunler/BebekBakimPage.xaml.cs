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
    public partial class BebekBakimPage : ContentPage
    {
        public BebekBakimPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=10,
                    Name = "Burun Aspiratörü",
                    Fiyat = 14,
                    Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/98/smBYP-199098_1.jpg"
                },
                new Giyim
                {
                    Id=11,
                    Name = "Bebek Pudra Kokusu",
                    Fiyat = 26,
                    Url ="https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/2558000170080_1.jpg"
                },
                new Giyim
                {
                    Id=12,
                    Name = "Bebek Tarağı",
                    Fiyat = 24,
                    Url ="https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8680075434546_1.jpg"
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