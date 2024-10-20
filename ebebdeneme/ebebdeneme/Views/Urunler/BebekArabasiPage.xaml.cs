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
    public partial class BebekArabasiPage : ContentPage
    {
        public BebekArabasiPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=8,
                    Name = "Bebek Arabası",
                    Fiyat = 1119,
                    Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/10/smJOI-S1112DJURB010_1.jpg"
                },
                new Giyim
                {
                    Id=9,
                    Name = "Joie Bebek Arabası",
                    Fiyat = 1401,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/25/smVIB-BUS-0425_1.jpg"
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