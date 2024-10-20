using ebebdeneme.ViewModels;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SilPage : ContentPage
    {
        public SilPage()
        {
            InitializeComponent();


        }
        async void Button_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CartView());
        }
    }
}