using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WebHost.Dao;
using WebHost.Interfaces;
using WebHost.Models;

namespace WebHost
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        private CustomerDao _customerDao;
        public OrderService()
        {
            _customerDao = new CustomerDao();
        }

        public void AddCustomer(Customer customer)
        {
            _customerDao.SaveCustomer(customer);
        }

        public List<Customer> GetCustomers()
        {
            return _customerDao.GetCustomers();
        }

        public void DeleteCustomer(Guid id)
        {
            _customerDao.DeleteCustomer(id);
        }
    }
}
