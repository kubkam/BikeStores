using BikeStores.Core;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace BikeStores.Data
{
    public class SqlBikeStoresRepository : IBikeStoresRepository
    {
        private readonly BikeStoresContext _bikeStoresContext;

        public SqlBikeStoresRepository(BikeStoresContext bikeStoresContext)
        {
            _bikeStoresContext = bikeStoresContext;
        }

        public Products ProductGetById(int id)
        {
            return _bikeStoresContext
                .Products
                .Include(b => b.Brand)
                .Include(c => c.Category)
                .FirstOrDefault(p => p.ProductId == id);
        }

        public IEnumerable<Products> GetAllProducts()
        {
            return _bikeStoresContext.Products
                .Include(b => b.Brand)
                .Include(c => c.Category);
        }

        public Products DeleteProduct(int id)
        {
            var product = ProductGetById(id);
            if (product != null)
            {
                _bikeStoresContext.Remove(product);
            }

            return product;
        }

        public Products AddProduct(Products newProduct)
        {
           _bikeStoresContext.Products.Add(newProduct);

           return newProduct;
        }

        public Products UpdateProduct(Products updatedProduct)
        {
            _bikeStoresContext.Update(updatedProduct);

            return updatedProduct;
        }

        public Brands BrandGetById(int id)
        {
            return _bikeStoresContext
                .Brands
                .FirstOrDefault(p => p.BrandId == id);
        }

        public IEnumerable<Brands> GetAllBrands()
        {
            return _bikeStoresContext
                .Brands;
        }

        public int SaveData()
        {
            return _bikeStoresContext.SaveChanges();
        }
    }
}
