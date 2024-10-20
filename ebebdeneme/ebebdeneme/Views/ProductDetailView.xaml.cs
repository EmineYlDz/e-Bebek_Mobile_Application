using ebebdeneme.Models;
using ebebdeneme.ViewModels;
using Xamarin.Forms;

namespace ebebdeneme.Views
{
   
    public partial class ProductDetailView : ContentPage
    {
         ProductDetailViewModel pvm;

        public ProductDetailView(Giyim giyim)
        {
            InitializeComponent();

            pvm = new ProductDetailViewModel(giyim);
            this.BindingContext = pvm;
        }

        async void ImageButton_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PopModalAsync();
            
        }

        
    }
}