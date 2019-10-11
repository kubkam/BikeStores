using BikeStores.Core;
using System.Collections.Generic;

namespace BikeStores.Data
{
    public interface IBikeStoresRepository
    {
        Products ProductGetById(int id);
        IEnumerable<Products> GetAllProducts();
        Products DeleteProduct(int id);
        Products AddProduct(Products newProduct);
        Products UpdateProduct(Products updatedProduct);

        Brands BrandGetById(int id);
        IEnumerable<Brands> GetAllBrands();

        int SaveData();
    }
}
