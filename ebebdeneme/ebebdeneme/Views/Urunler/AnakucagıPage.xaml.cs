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
    public partial class AnakucagıPage : ContentPage
    {
        public AnakucagıPage()
        {
            InitializeComponent();
            List<Giyim> giyims = new List<Giyim>()
            {


                
                new Giyim
                {
                    Id=1,
                    Name = "Oyuncaklı Anakucağı",
                    Fiyat = 139,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/97/smBYP-LOU-0197_1.jpg"
                },
                new Giyim
                {
                    Id=2,
                    Name = "Lucca Ana Kucağı",
                    Fiyat = 99,
                    Url ="https://cdn.e-bebek.com/www.ebebek/i/p/200/53/smBYP-ACT-0653_1.jpg"
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