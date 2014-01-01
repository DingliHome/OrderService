using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHost.Models;

namespace WebHost.Dao
{
    public class RestaurantDao
    {
        private OrderDBContext _orderDbContext;
        public RestaurantDao()
        {
            _orderDbContext = new OrderDBContext();
            _orderDbContext.Configuration.ProxyCreationEnabled = false;
        }

        public List<Restaurant> GetRestaurants()
        {
            return _orderDbContext.Restaurants.ToList();
        }

        public void SaveRestaurant(Restaurant restaurant)
        {
            _orderDbContext.Restaurants.Add(restaurant);
            var saveChanges = _orderDbContext.SaveChanges();

        }

        public void DeleteRestaurant(Guid id)
        {
            var restaurant = _orderDbContext.Restaurants.FirstOrDefault(x => x.RestaurantId == id);
            if (restaurant != null)
                _orderDbContext.Restaurants.Remove(restaurant);

            _orderDbContext.SaveChanges();
        }
    }
}