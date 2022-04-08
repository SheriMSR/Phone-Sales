using Business_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetOrderDetails();
        OrderDetail GetOrderDetailByID(string OrderId, string ProductId);
        void InsertOrderDetail(OrderDetail OrderDetail);
        void DeleteOrderDetail(string OrderId, string ProductId);
        void UpdateOrderDetail(OrderDetail OrderDetail);

    }
}
