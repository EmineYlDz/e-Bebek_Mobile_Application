using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Models;
using ebebdeneme.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AyakkabiPage : ContentPage
    {
        //public List<Giyim> Giyims = new List<Giyim>();

         
        public AyakkabiPage()
        {
            InitializeComponent();
            BindingContext = new AyakkabiViewModel();
            List<Giyim> giyims = new List<Giyim>()
            {
               
                
                new Giyim
                {
                    Id=3,
                    Name = "HelloBaby Ayakkabı",
                    Fiyat = 49,
                    Url = "https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000065462_1.jpg"
                },
                new Giyim
                {
                    Id=4,
                    Name = "CicCi Çorap",
                    Fiyat = 9,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/EM/lGENHELKCRP6207PEM_1.jpg" 
                },
                new Giyim
                {
                    Id=5,
                    Name = "First Step Erkek Bebek",
                    Fiyat = 29,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/28/l20YFSPKAYK005-0028_1.jpg" 
                },
                new Giyim
                {
                    Id=6,
                    Name = "First Step Kız Bebek",
                    Fiyat = 29,
                    Url ="https://cdn.e-bebek.com/mnresize/1000/-/www.ebebek/i/p/hd/32/l20YFSPKAYK007-0032_1.jpg"
                },
                new Giyim
                {
                    Id=7,
                    Name = "Kiraz Patik",
                    Fiyat = 12,
                    Url ="https://cdn.e-bebek.com/mnresize/1600/1600/y.ebebek/prod/productImage/1990000072664_1.jpg"
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