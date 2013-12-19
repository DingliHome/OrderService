using System;
using System.Collections.Generic;

namespace WebHost.Models
{
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        public System.Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Nullable<System.DateTime> RegisterTime { get; set; }
        public Nullable<System.DateTime> LastLogonTime { get; set; }
        public string IP { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
