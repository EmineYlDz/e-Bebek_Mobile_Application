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
    public partial class IcGiyimPage : ContentPage
    {
        public IcGiyimPage()
        {
            InitializeComponent();
            
            BindingContext = new IcGiyimViewModel();
           
            List<Giyim> giyims = new List<Giyim>()
            {


                new Giyim
                {
                    Id=30,
                    Name = "2'li Bebek Atlet",
                    Fiyat = 14,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/AV/lGENHELEALT6254MAV_1.jpg"
                },
                new Giyim
                {
                    Id=31,
                    Name = "2'li Penti",
                    Fiyat = 16,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/04/lGENHBLKKLT004-0004_1.jpg"
                },
                new Giyim
                {
                    Id=32,
                    Name = "Kayıp Timsah Atlet",
                    Fiyat = 12,
                    Url = "https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/51/l20YFPREALT014-0051_1.jpg"
                },
                new Giyim
                {
                    Id=33,
                    Name = "Tatlı Kiraz Atlet",
                    Fiyat = 13,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/22/l20YFPRKALT051-0022_1.jpg"
                },
                new Giyim
                {
                    Id=34,
                    Name = "Nemo Atlet",
                    Fiyat = 17,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/07/l20YDISEALT058-0007_1.jpg"
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