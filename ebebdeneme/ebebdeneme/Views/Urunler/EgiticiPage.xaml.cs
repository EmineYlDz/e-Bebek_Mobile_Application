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
    public partial class EgiticiPage : ContentPage
    {
        public EgiticiPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=27,
                    Name = "Eğitici Top",
                    Fiyat = 10,
                    Url = "https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8682250032523_1.jpg"
                },
                new Giyim
                {
                    Id=28,
                    Name = "Bowling Seti",
                    Fiyat = 19,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/77/smBYT-1277_1.jpg"
                },
                new Giyim
                {
                    Id=29,
                    Name = "Çizim Tableti",
                    Fiyat = 39,
                    Url ="https://cdn.e-bebek.com/mnresize/274/274/y.ebebek/prod/productImage/8698540308643_1.jpg"
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