
using Business_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    public class OrderDAO
    {
        //Using Singleton Pattern
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Order> GetOrderList()
        {
            var members = new List<Order>();
            try
            {
                using var context = new PhoneSaleManagementContext();
                members = context.Orders.ToList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return members;

        }

        public Order GetOrderByID(string OrderId)
        {
            Order mem = null;
            try
            {
                using var context = new PhoneSaleManagementContext();
                mem = context.Orders.SingleOrDefault(c => c.orderId == OrderId);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return mem;
        }

        //-----------------------------------------------------------------
        //Add a new order
        public void AddNew(Order Order)
        {
            try
            {
                Order mem = GetOrderByID(Order.orderId);
                if (mem == null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Orders.Add(Order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order is already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        //-----------------------------------------------------------------
        //Update an order
        public void Update(Order Order)
        {
            try
            {
                Order mem = GetOrderByID(Order.orderId);
                if (mem != null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Orders.Update(Order);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        //-----------------------------------------------------------------
        //Remove an order
        public void Remove(string OrderId)
        {
            try
            {
                Order mem = GetOrderByID(OrderId);
                if (mem != null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Orders.Remove(mem);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("The Order does not already exist.");
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}