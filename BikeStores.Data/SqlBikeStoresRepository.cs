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

        public IEnumerable<Products> GetProducts()
        {
            return _bikeStoresContext.Products
                .Include(b => b.Brand)
                .Include(c => c.Category);
        }
    }
}
