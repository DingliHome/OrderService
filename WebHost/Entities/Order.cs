using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace WebHost.Models
{
    [DataContract(IsReference = true)]
    public partial class Order
    {
        [DataMember]
        public System.Guid OrderId { get; set; }
        [DataMember]
        public System.Guid CustomerId { get; set; }
        [DataMember]
        public System.Guid RestaurantId { get; set; }
        [DataMember]
        public virtual Customer Customer { get; set; }
        [DataMember]
        public virtual Restaurant Restaurant { get; set; }
    }
}
