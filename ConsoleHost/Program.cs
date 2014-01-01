using System;
using ConsoleHost.ServiceAPIS;
using WebHost.Models;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new OrderServiceClient();
            //client.AddCustomer(new Customer() { Id = Guid.NewGuid(), Name = "dingli" });

            var customers = client.GetCustomers();


        }
    }
}
