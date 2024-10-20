using ebebdeneme.Models;
using ebebdeneme.Services;
using ebebdeneme.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ebebdeneme.ViewModels
{
    public class CartViewModel : BaseViewModel
    {
        public ObservableCollection<UserCartItem> CartItems { get; set; }
        private decimal _TotalCost;
        public decimal TotalCost
        {
            set
            {
                _TotalCost = value;
                OnPropertyChanged();
            }
            get
            {
                return _TotalCost;
            }

        }
        public Command PlaceOrderCommand { get; set; }
        public CartViewModel()
        {
            CartItems = new ObservableCollection<UserCartItem>();
            LoadItems();
            PlaceOrderCommand = new Command(async () => await PlaceOrderAsync());
        }

        private async Task PlaceOrderAsync()
        {   //sipariş sayfası
            var id = await new OrderService().PlaceOrderAsync() as string;
            RemoveItemsFromCart();
            await Application.Current.MainPage.Navigation.PushModalAsync(new OrdersView(id));
           
        }

        private void RemoveItemsFromCart()
        {
            var cis = new CartItemService();
            cis.RemoveItemsFromCart();
        }

        private void LoadItems()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var items = cn.Table<CartItem>().ToList();
            CartItems.Clear();

            foreach(var item in items)
            {
                CartItems.Add(new UserCartItem()
                {
                    CartItemId = item.CartItemId,
                    Id = item.Id,
                    GiyimName = item.GiyimName,
                    Fiyat = item.Fiyat,
                    Quantity = item.Quantity,
                    Cost = item.Fiyat * item.Quantity
                });
                TotalCost += (item.Fiyat * item.Quantity);

            }
        }   
    }  
}
