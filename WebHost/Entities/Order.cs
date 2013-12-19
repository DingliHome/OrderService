using System;
using System.Collections.Generic;

namespace WebHost.Models
{
    public partial class Order
    {
        public System.Guid OrderId { get; set; }
        public System.Guid CustomerId { get; set; }
        public System.Guid RestaurantId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
