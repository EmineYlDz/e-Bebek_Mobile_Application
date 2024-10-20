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
    public partial class BebekOdasiAksesuarPage : ContentPage
    {
        public BebekOdasiAksesuarPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=21,
                    Name = "Baby Memory Prints",
                    Fiyat = 64,
                    Url = "https://cdn.e-bebek.com/www.ebebek/i/p/200/02/smBMP-081002_1.jpg"
                },
                new Giyim
                {
                    Id=22,
                    Name = "Mycey",
                    Fiyat = 29,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/04/smMYC-24000004_1.jpg"
                },
                new Giyim
                {
                    Id=23,
                    Name = "Nazarık Bebek Ayak İzi",
                    Fiyat = 39,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/20/smBMP-14620_1.jpg"
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