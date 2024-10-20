using ebebdeneme.ViewModels;
using ebebdeneme.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ebebdeneme
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            //Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
            Routing.RegisterRoute("LoginPage", typeof(LoginPage));
            Routing.RegisterRoute("OrdersView", typeof(OrdersView));
            Routing.RegisterRoute("AboutPage", typeof(AboutPage));
            Routing.RegisterRoute("CategoryView", typeof(CategoryView));
            Routing.RegisterRoute("ProductDetailView", typeof(ProductDetailView));
            Routing.RegisterRoute("AppShell", typeof(AppShell));




        }

       private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
