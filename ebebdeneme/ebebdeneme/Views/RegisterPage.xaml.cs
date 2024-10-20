using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ebebdeneme.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ebebdeneme.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

       /* private void Button_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),"UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<User>();

            var item = new User()
            {
                KullanıcıAdı = EntryUserName.Text,
                Şifre = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                Telefon = EntryUserPhoneNumber.Text
            };

            db.Insert(item);
            
            Device.BeginInvokeOnMainThread(async() => {

                var result = await this.DisplayAlert("Tebrikler", "Giriş Başarılı", "Yes", "Cancel");

                if (result)
                    await Navigation.PushAsync(new LoginPage());


            });
            
        }*/
    }
}