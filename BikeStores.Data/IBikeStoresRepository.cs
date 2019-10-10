using System;
using System.Collections.Generic;
using System.Text;
using BikeStores.Core;

namespace BikeStores.Data
{
    public interface IBikeStoresRepository
    {
        Products ProductGetById(int id);
    }
}
