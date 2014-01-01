using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHost.Models;

namespace WebHost.Dao
{
    public class OrderDao
    {
        private OrderDBContext _orderDbContext;
        public OrderDao()
        {
            _orderDbContext = new OrderDBContext();
            _orderDbContext.Configuration.ProxyCreationEnabled = false;
        }

        public List<Order> GetOrders()
        {
            return _orderDbContext.Orders.ToList();
        }

        public void SaveOrder(Order order)
        {
            _orderDbContext.Orders.Add(order);
            var saveChanges = _orderDbContext.SaveChanges();
        }

        public void DeleteOrder(Guid id)
        {
            var order = _orderDbContext.Orders.FirstOrDefault(x => x.OrderId == id);
            if (order != null)
                _orderDbContext.Orders.Remove(order);

            _orderDbContext.SaveChanges();
        }
    }
}