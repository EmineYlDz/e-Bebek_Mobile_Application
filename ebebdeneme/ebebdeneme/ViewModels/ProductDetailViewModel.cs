using ebebdeneme.Models;
using ebebdeneme.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ebebdeneme.ViewModels
{
    public class ProductDetailViewModel : BaseViewModel
    {
        private Giyim _SelectedGiyim;
        public Giyim SelectedGiyim
        {
            set
            {
                _SelectedGiyim = value;
                OnPropertyChanged();
            }
            get
            {
                return _SelectedGiyim;
            }
        }
       
        
        private int _TotalQuantity;
        
        public int TotalQuantity
        {
            set
            {
                this._TotalQuantity = value;
              
                if (this._TotalQuantity < 0)
                    this._TotalQuantity = 0;
                if (this._TotalQuantity > 10)
                    this._TotalQuantity -= 1;
                
                OnPropertyChanged();
            }
            get
            {
                return _TotalQuantity;
            }
        }
        public Command IncrementOrderCommand { get; set; }
        public Command DecrementOrderCommand { get; set; }
        public Command AddToCartCommand { get; set; }
        public Command ViewToCartCommand { get; set; }
        public Command HomeCommand { get; set; }

        public ProductDetailViewModel(Giyim giyim)
        {
            SelectedGiyim = giyim ;
            TotalQuantity = 0 ;
            IncrementOrderCommand = new Command(() => IncrementOrder());
            DecrementOrderCommand = new Command(() => DecrementOrder());
            AddToCartCommand = new Command(() => AddToCart());
            ViewToCartCommand = new Command(async () => await ViewToCartAsync());
            HomeCommand = new Command(async () => await GoToHomeAsync());

        }

        private async Task GoToHomeAsync()
        {
            // await Application.Current.MainPage.Navigation.PushModalAsync(new AppShell());
            await Shell.Current.GoToAsync("/AboutPage");

        }

        private async Task ViewToCartAsync()
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CartView());
            

        }

        private void AddToCart()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            try
            {
                CartItem ci = new CartItem()
                {
                    Id = SelectedGiyim.Id,
                    GiyimName = SelectedGiyim.Name,
                    Fiyat = SelectedGiyim.Fiyat,
                    Quantity = TotalQuantity
                };
                var item = cn.Table<CartItem>().ToList()
                    .FirstOrDefault(c => c.Id == SelectedGiyim.Id);
                if (item == null)
                    cn.Insert(ci);
                else
                {
                    item.Quantity += TotalQuantity;
                    cn.Update(item);
                }
                cn.Commit();
                cn.Close();
                Application.Current.MainPage.DisplayAlert("Cart", "Kart Bilgileriniz Kaydetildi", "OK");
                
            }
            catch(Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Hata", ex.Message, "OK");
            }
            finally
            {
                cn.Close();
            }
            
        }

        private void DecrementOrder()
        {
            TotalQuantity--;
        }

        private void IncrementOrder()
        {
            TotalQuantity++;
        }
    }
}
