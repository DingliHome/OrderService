using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebHost.Models;

namespace WebHost.Dao
{
    public class CustomerDao
    {
        private OrderDBContext _orderDbContext;

        public CustomerDao()
        {
            _orderDbContext = new OrderDBContext();
        }

        public List<Customer> GetCustomers()
        {
            return _orderDbContext.Customers.ToList();
        }

        public void SaveCustomer(Customer customer)
        {
            _orderDbContext.Customers.Add(customer);
            var saveChanges = _orderDbContext.SaveChanges();

        }

        public void DeleteCustomer(Guid id)
        {
            var customer = _orderDbContext.Customers.FirstOrDefault(x => x.Id == id);
            if (customer!=null)
                _orderDbContext.Customers.Remove(customer);

            _orderDbContext.SaveChanges();
        }
    }
}