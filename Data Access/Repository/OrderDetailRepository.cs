using Business_Object.Models;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        public IEnumerable<OrderDetail> GetOrderDetails() => OrderDetailDAO.Instance.GetOrderDetailList();
        public OrderDetail GetOrderDetailByID(string OrderId, string ProductId) => OrderDetailDAO.Instance.GetOrderDetailByID(OrderId, ProductId);
        public void InsertOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.AddNew(OrderDetail);
        public void DeleteOrderDetail(string OrderId, string ProductId) => OrderDetailDAO.Instance.Remove(OrderId, ProductId);
        public void UpdateOrderDetail(OrderDetail OrderDetail) => OrderDetailDAO.Instance.Update(OrderDetail);
    }
}
