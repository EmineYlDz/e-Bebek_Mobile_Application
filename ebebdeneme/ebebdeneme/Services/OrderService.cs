using ebebdeneme.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace ebebdeneme.Services
{
    
    public class OrderService
    {
        FirebaseClient Client;
       public OrderService()
        {
            Client = new FirebaseClient("https://ebebek-c02cb-default-rtdb.firebaseio.com/");
        }
        
        public async Task<string> PlaceOrderAsync()
        {
            var cn = DependencyService.Get<ISQLite>().GetConnection();
            var data = cn.Table<CartItem>().ToList();
            var orderId = Guid.NewGuid().ToString();
            var uname = Preferences.Get("Username", "Guest");
            decimal totalCost = 0;
            foreach (var item in data) 
            {
                OrderDetails od = new OrderDetails()
                {
                    OrderId = orderId,
                    OrderDetailId = Guid.NewGuid().ToString(),
                    Id = item.Id,
                    GiyimName = item.GiyimName,
                    Fiyat = item.Fiyat,
                    Quentity = item.Quantity
                };
                totalCost += item.Fiyat * item.Quantity;
                await Client.Child("OrderDetails").PostAsync(od);
            }
            await Client.Child("Order").PostAsync(
                new Order()
                {
                    OrderId = orderId,
                    Username = uname,
                    TotalCost = totalCost
                });
            return orderId;
        }
    }
}
