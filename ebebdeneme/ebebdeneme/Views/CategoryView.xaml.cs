﻿using ebebdeneme.Models;
using ebebdeneme.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    //[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CategoryView : ContentPage
    {
        CategoryViewModel cvm;
        public CategoryView(Category category)
        {
            InitializeComponent();
            cvm = new CategoryViewModel(category);
            this.BindingContext = cvm;
        }

        async void ImageButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = e.CurrentSelection.FirstOrDefault() as Giyim;
            if (selectedProduct == null)
                return;
            await Navigation.PushModalAsync(new ProductDetailView(selectedProduct));
            ((CollectionView)sender).SelectedItem = null;
        }
    }
}//,StringFormat='{0} TotalItems'