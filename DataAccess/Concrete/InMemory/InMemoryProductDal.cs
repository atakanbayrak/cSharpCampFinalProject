using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { 
                new Product{ProductId = 1, ProductName = "Bardak", CategoryId = 1, UnitPrice = 3, UnitsInStock = 3},
                new Product{ProductId = 2, ProductName = "Kamera", CategoryId = 1, UnitPrice = 3, UnitsInStock = 3},
                new Product{ProductId = 3, ProductName = "Su", CategoryId = 2, UnitPrice = 3, UnitsInStock = 3},
                new Product{ProductId = 4, ProductName = "Sut", CategoryId = 2, UnitPrice = 3, UnitsInStock = 3},
                new Product{ProductId = 5, ProductName = "Catal", CategoryId = 2, UnitPrice = 3, UnitsInStock = 3}
            };
        }
        
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete); 
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
