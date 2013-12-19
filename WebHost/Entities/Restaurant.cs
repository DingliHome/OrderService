using System;
using System.Collections.Generic;

namespace WebHost.Models
{
    public partial class Restaurant
    {
        public Restaurant()
        {
            this.Orders = new List<Order>();
        }

        public System.Guid RestaurantId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Type { get; set; }
        public string Phone { get; set; }
        public string TelPhone { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Mark { get; set; }
        public Nullable<decimal> AtLestCost { get; set; }
        public Nullable<decimal> DeliveRange { get; set; }
        public Nullable<int> Discount { get; set; }
        public Nullable<bool> IsDelivery { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
