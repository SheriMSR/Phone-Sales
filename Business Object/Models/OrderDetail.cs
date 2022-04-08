using System;
using System.Collections.Generic;

#nullable disable

namespace Business_Object.Models
{
    public partial class OrderDetail
    {
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public double? TotalPrice { get; set; }
        public int? Quantity { get; set; }
        public double? Discount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
