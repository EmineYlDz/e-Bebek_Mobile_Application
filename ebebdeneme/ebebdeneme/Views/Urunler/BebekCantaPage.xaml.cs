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
    public partial class BebekCantaPage : ContentPage
    {
        public BebekCantaPage()
        {
            InitializeComponent();
            BindingContext = new BebekCantaViewModel();

            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=16,
                    Name = "Dinazor Çocuk Çantası",
                    Fiyat = 49,
                    Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065189_1.jpg"
                },
                new Giyim
                {
                    Id=17,
                    Name = "Fil Figürlü Çanta",
                    Fiyat = 54,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/lGENFPRUCNT003-0032_1.jpg"
                },
                new Giyim
                {
                    Id=18,
                    Name = "Panda Figürlü Çanta",
                    Fiyat = 69,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/lGENFPRUCNT004-0022_1.jpg"
                },
                new Giyim
                {
                    Id=19,
                    Name = "Çocuk Valizi Beyaz",
                    Fiyat = 199,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/27/lOXO-8427_1.jpg"
                },
                new Giyim
                {
                    Id=20,
                    Name = "Kedi Bebek Sırt Çantası",
                    Fiyat = 69,
                    Url ="https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065799_1.jpg"
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
