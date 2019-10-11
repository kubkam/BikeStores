using BikeStores.Core;
using System.Collections.Generic;

namespace BikeStores.Data
{
    public interface IBikeStoresRepository
    {
        Products ProductGetById(int id);
        IEnumerable<Products> GetProducts();
    }
}
