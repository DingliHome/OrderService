using System;
using WebHost.Models;

namespace ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ServiceAPIS.OrderServiceClient();
            client.GetCustomers();
        }
    }
}
