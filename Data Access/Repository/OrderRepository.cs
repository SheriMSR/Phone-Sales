using Business_Object.Models;
using Data_Access.Repository;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public IEnumerable<Order> GetOrders() => OrderDAO.Instance.GetOrderList();
        public Order GetOrderByID(string OrderId) => OrderDAO.Instance.GetOrderByID(OrderId);
        public void InsertOrder(Order Order) => OrderDAO.Instance.AddNew(Order);
        public void DeleteOrder(string OrderId) => OrderDAO.Instance.Remove(OrderId);
        public void UpdateOrder(Order Order) => OrderDAO.Instance.Update(Order);

        public void DeleteOrderDetail(string orderId, string productId) => OrderDAO.Instance.Remove(productId);
    }
}
