using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Helpers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentPage
    {
        public SettingPage()
        {
            InitializeComponent();
        }

        async void ButtonCategories_Clicked(System.Object sender, System.EventArgs e)
        {
            var acd = new AddCategoryData();
            await acd.AddCategoriesAsync();
        }

        async void ButtonProducts_Clicked(System.Object sender, System.EventArgs e)
        {
            var agd = new AddGiyimData();
            await agd.AddGiyimAsync();
        }

        private void ButtonCart_Clicked(System.Object sender, System.EventArgs e)
        {
            var cct = new CreateCartTable();

            if (cct.CreateTable())
                DisplayAlert("Başarılı", "Kart Tablosu Oluşturuldu", "OK");
            else
                DisplayAlert("Hata", "Kart Tablosu Oluşturulamadı", "OK");
        }
    }
}