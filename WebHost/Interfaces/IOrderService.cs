using System;
using System.Collections.Generic;
using System.ServiceModel;
using WebHost.Models;

namespace WebHost.Interfaces
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        #region Customer
        [OperationContract]
        void AddCustomer(Customer customer);
        [OperationContract]
        List<Customer> GetCustomers();
        [OperationContract]
        void DeleteCustomer(Guid id);
        #endregion

        #region Order
        [OperationContract]
        void AddOrder(Order order);
        [OperationContract]
        List<Order> GetOrders();
        [OperationContract]
        void DeleteOrder(Guid id);
        #endregion

        #region Restaurant
        [OperationContract]
        void AddRestaurant(Restaurant restaurant);
        [OperationContract]
        List<Restaurant> GetRestaurants();
        [OperationContract]
        void DeleteRestaurant(Guid id);
        #endregion
    }
}
