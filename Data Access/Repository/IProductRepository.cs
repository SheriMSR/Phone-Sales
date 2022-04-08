using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business_Object.Models;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        IEnumerable<Product> SearchProByName(string proName);
        public Product GetProductByID(string id);
        public void AddProduct(Product product);
        public void UpdateProduct(Product product);
        public void RemoveProduct(Product product);
    }
}
