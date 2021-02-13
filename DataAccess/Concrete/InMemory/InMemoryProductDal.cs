using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemorry
{
    public class InMemoryProductDal : IProductDal
    {

        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>() { 
            new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnicPrice=15,UnitysInStock=15},
            new Product{ProductId=2,CategoryId=2,ProductName="dak",UnicPrice=15,UnitysInStock=15},
            new Product{ProductId=3,CategoryId=3,ProductName="rdak",UnicPrice=15,UnitysInStock=15},
            new Product{ProductId=4,CategoryId=4,ProductName="ardak",UnicPrice=15,UnitysInStock=15}

            }; 
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);

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
        {//Linq -> Language Integreted Query,Dile gömülü sorgu

            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate= _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnicPrice = product.UnicPrice;
            productToUpdate.UnitysInStock = product.UnitysInStock;
            productToUpdate.CategoryId = product.CategoryId;


        }
    }
}
