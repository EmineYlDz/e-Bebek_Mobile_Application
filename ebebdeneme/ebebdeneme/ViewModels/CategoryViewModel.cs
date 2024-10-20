using ebebdeneme.Models;
using ebebdeneme.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace ebebdeneme.ViewModels
{
    public partial class CategoryViewModel : BaseViewModel
    {
        private Category _SelectedCategory;
        public Category SelectedCategory
        {
            set
            {
                _SelectedCategory = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedCategory;
            }
        }

        private int _TotalGiyims;
        public int TotalGiyims
        {
            set
            {
                _TotalGiyims = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalGiyims;
            }
        }

        public ObservableCollection<Giyim> GiyimsByCategory { get; set; }
        public CategoryViewModel(Category category)
        {
            SelectedCategory = category;
            GiyimsByCategory = new ObservableCollection<Giyim>();
            GetGiyims(category.CategoryID);
        }

        private async void GetGiyims(int categoryID)
        {
            var data = await new GiyimService().GetGiyimsByCategoryAsync(categoryID);
            GiyimsByCategory.Clear();
            foreach (var item in data)
            {
                GiyimsByCategory.Add(item);
            }

            TotalGiyims = GiyimsByCategory.Count;

        }
    }
}
