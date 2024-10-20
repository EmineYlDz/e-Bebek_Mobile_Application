using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using ebebdeneme.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ebebdeneme.Helpers;
using ebebdeneme.ViewModels;
using Firebase.Database;
using System.Threading.Tasks;
using Firebase.Database.Query;

namespace ebebdeneme.Views
{
    public partial class AboutPage :ContentPage
    {
       
        public AboutPage()
        {
            InitializeComponent();
           
        }
        
        async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
        async void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

       

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var category = e.CurrentSelection.FirstOrDefault() as Category;
            if (category == null)
                return;

            await Navigation.PushModalAsync(new CategoryView(category));
            ((CollectionView)sender).SelectedItem = null;

        }

        /*async  void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }*/
    }
}