using Business_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace DataAccess
{
    public class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetProducts()
        {
            var members = new List<Product>();
            try
            {
                using var context = new PhoneSaleManagementContext();
                members = context.Products.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return members;
        }
        public Product GetProductByID(string id)
        {
            Product product = null;
            try
            {
                using var context = new PhoneSaleManagementContext();
                product = context.Products.SingleOrDefault(e => e.ProductId == id);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return product;
        }

        public void AddProduct(Product product)
        {
            try
            {
                Product pro = GetProductByID(product.ProductId);
                if (pro == null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Products.Add(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This product has already existed!");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void UpdateProduct(Product product)
        {
            try
            {
                var check = GetProductByID(product.ProductId);
                if (check == null)
                {
                    throw new Exception("This product is not existed.");
                }
                else
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Products.Update(product);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void RemoveProduct(Product product)
        {
            try
            {
                var check = GetProductByID(product.ProductId);
                if (check != null)
                {
                    using var context = new PhoneSaleManagementContext();
                    context.Products.Remove(product);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("This product is not existed.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> SearchProductByName(string pname)
        {
            var pros = ProductDAO.Instance.GetProducts();
            IEnumerable<Product> list = from product in pros
                                       where (product.ProductName.ToLower().Contains(pname.ToLower()))
                                       select product;
            return list;
        }

    }
}
