using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CıkısPage : ContentPage
    {
        public CıkısPage()
        {
            InitializeComponent();
        }
        async void Button_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new AboutPage());
           
        }
    }
}