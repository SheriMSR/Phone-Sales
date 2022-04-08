using System;
using System.Collections.Generic;

#nullable disable

namespace Business_Object.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBrand { get; set; }
        public double? ProductPrice { get; set; }
        public int? ProductQuantity { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
