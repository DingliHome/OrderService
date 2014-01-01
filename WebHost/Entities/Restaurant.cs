using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebHost.Models
{
    [DataContract(IsReference = true)]
    public partial class Restaurant
    {
        public Restaurant()
        {
            this.Orders = new List<Order>();
        }
        [DataMember]
        public System.Guid RestaurantId { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public string TelPhone { get; set; }
        [DataMember]
        public Nullable<System.DateTime> StartTime { get; set; }
        [DataMember]
        public Nullable<System.DateTime> EndTime { get; set; }
        [DataMember]
        public string Mark { get; set; }
        [DataMember]
        public Nullable<decimal> AtLestCost { get; set; }
        [DataMember]
        public Nullable<decimal> DeliveRange { get; set; }
        [DataMember]
        public Nullable<int> Discount { get; set; }
        [DataMember]
        public Nullable<bool> IsDelivery { get; set; }
        [DataMember]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
