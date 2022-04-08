using Business_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetOrders();
        Order GetOrderByID(string OrderId);
        void InsertOrder(Order order);
        void DeleteOrder(string OrderID);
        void UpdateOrder(Order order);
        void DeleteOrderDetail(string orderId, string productId);
    }
}
