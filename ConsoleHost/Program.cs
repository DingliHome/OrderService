using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Text;
using WebHost;
using WebHost.Models;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var orderService = new OrderService();
            orderService.AddCustomer(new Customer() { Id = Guid.NewGuid(), Name = "dingli" });
        }
    }
}
