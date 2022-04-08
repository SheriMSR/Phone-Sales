using Business_Object.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void AddProduct(Product product) => ProductDAO.Instance.AddProduct(product);

        public Product GetProductByID(string id) => ProductDAO.Instance.GetProductByID(id);

        public List<Product> GetProducts() => ProductDAO.Instance.GetProducts();

        public void RemoveProduct(Product product) => ProductDAO.Instance.RemoveProduct(product);

        public IEnumerable<Product> SearchProByName(string pname) => ProductDAO.Instance.SearchProductByName(pname);

        public void UpdateProduct(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
