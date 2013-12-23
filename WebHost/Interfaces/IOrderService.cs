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
        [OperationContract]
        void AddCustomer(Customer customer);
        [FaultContract(typeof(string))]
        [OperationContract]
        List<Customer> GetCustomers();
        [OperationContract]
        void DeleteCustomer(Guid id);
    }
}
