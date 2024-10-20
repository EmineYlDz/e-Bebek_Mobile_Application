using ebebdeneme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class OrdersView : ContentPage
    {
       
        public OrdersView(string id)
        {
            InitializeComponent();
            LabelName.Text = "HOŞ GELDİNİZ" + Preferences.Get("Username", "Guest") + ",";
            LabelOrderID.Text = id;
            

        }

        async void Button_Clicked(System.Object sender, EventArgs e)
        {
            // await Navigation.PushModalAsync(new AppShell());
            await Shell.Current.GoToAsync("/AboutPage");
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        
       
    }
}