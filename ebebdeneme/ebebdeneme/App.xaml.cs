using ebebdeneme.Models;
using ebebdeneme.Services;
using ebebdeneme.Views;
using SQLite;
using System;
using System.IO;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme
{
    public partial class App : Application
    {
        public SQLiteConnection cn;

        public App()
        {
            InitializeComponent();

             DependencyService.Register<MockDataStore>();
             MainPage = new  AppShell();
            // MainPage = new NavigationPage(new SettingPage());

            //cn = DependencyService.Get<ISQLite>().GetConnection();
            //cn.CreateTable<CartItem>();
            
            string uname = Preferences.Get("Username", String.Empty);

            if (String.IsNullOrEmpty(uname))
            {
                MainPage = new LoginPage();
            }

            else
                MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
