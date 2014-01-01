using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebHost.Models
{
    [DataContract(IsReference = true)]
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new List<Order>();
        }

        [DataMember]
        public System.Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public Nullable<System.DateTime> RegisterTime { get; set; }
        [DataMember]
        public Nullable<System.DateTime> LastLogonTime { get; set; }
        [DataMember]
        public string IP { get; set; }
        [DataMember]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
