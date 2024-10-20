using ebebdeneme.Models;
using ebebdeneme.Services;
using ebebdeneme.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;



namespace ebebdeneme.ViewModels
{
    public class GiyimViewModel : BaseViewModel
    {
        private string _UserName;
        public string UserName
        {
            set
            {
                _UserName = value;



                OnPropertyChanged();
            }
            get
            {
                return _UserName;
            }
        }



        private int _UserCartItemsCount;
        public int UserCartItemsCount
        {
            set
            {
                _UserCartItemsCount = value;



                OnPropertyChanged();
            }
            get
            {
                return _UserCartItemsCount;
            }
        }

        public ObservableCollection<Category> Categories { get; set; }
        public ObservableCollection<Giyim> IList { get; set; }




        public Command ViewCartCommand { get; set; }
        public Command LogoutCommand { get; set; }



        //public List<Category> Categories { get; set; }
        public ICommand OpenWebCommand { get; }
        public List<Firsat> Firsats { get; set; }
        public GiyimViewModel()
        {
            Firsats = new List<Firsat>()
            {
                new Firsat()
                {
                    FirsatName="Anne Bebek",
                    FirsatUrl="annebebek.jpg"

                },
                new Firsat()
                {
                    FirsatName="Bebek Arabaları",
                    FirsatUrl="arababebek.jpg"
                },
                new Firsat()
                {
                   FirsatName="Bebek Bezleri",
                    FirsatUrl="bebekbezi.jpg"
                },
            };




            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));



            var uname = Preferences.Get("Username", String.Empty);
            if (String.IsNullOrEmpty(uname))
                UserName = "Guest";
            else
                UserName = uname;



            UserCartItemsCount = new CartItemService().GetUserCartCount();



            Categories = new ObservableCollection<Category>();
            IList = new ObservableCollection<Giyim>();



            ViewCartCommand = new Command(async () => await ViewCartAsync());
            LogoutCommand = new Command(async () => await LogoutAsync());

            GetCategories();
            GetLatesGiyims();
        }



        private async Task LogoutAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new LogoutVew());
        }



        private async Task ViewCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());

        }



        private async void GetLatesGiyims()
        {
            var data = await new GiyimService().GetLatesGiyimsAsync();
            IList.Clear();



            foreach (var item in data)
            {
                IList.Add(item);
            }

        }



        private async void GetCategories()
        {
            var data = await new CategoryDataService().GetCategoriesAsync();
            Categories.Clear();



            foreach (var item in data)
            {
                Categories.Add(item);
            }

        }
    }
}