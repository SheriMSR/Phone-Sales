using System;
using System.Collections.Generic;

#nullable disable

namespace Business_Object.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string orderId { get; set; }
        public DateTime OrderDate { get; set; }
        public string MemberId { get; set; }

        public virtual Member Member { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
