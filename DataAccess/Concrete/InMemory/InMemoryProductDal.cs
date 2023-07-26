using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductID = 1, CategoryID = 1,ProductName = "Bardak",UnitPrice = 15, UnitsInStock = 5 },
            new Product{ProductID = 2, CategoryID = 1,ProductName = "Kamera",UnitPrice = 45000, UnitsInStock = 3 },
            new Product{ProductID = 3, CategoryID = 2,ProductName = "Telefon",UnitPrice = 15000, UnitsInStock = 2 },
            new Product{ProductID = 4, CategoryID = 2,ProductName = "Klavye",UnitPrice = 3000, UnitsInStock = 65 },
            new Product{ProductID = 5, CategoryID = 2,ProductName = "Fare",UnitPrice = 985, UnitsInStock = 1 }


            };
            
            
        }
        public void Add(Product product)
        {
          _products.Add(product);
        }

        public void Delete(Product product)
        {

            Product productToDelete = null; 
            productToDelete = _products.SingleOrDefault(p=>p.ProductID == product.ProductID);
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
            return _products.Where(p => p.CategoryID == categoryId).ToList();
        }

        public List<ProductDetailDto> getProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ID'sine sahip olan listedeki ürünü bul.
           Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock= product.UnitsInStock;



        }
    }
}
