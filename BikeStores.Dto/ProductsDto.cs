using System;
using System.Collections.Generic;

namespace BikeStores.Dto
{
    public class ProductsDto
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }

        public virtual BrandsDto BrandDto { get; set; }
        public virtual CategoriesDto CategoryDto { get; set; }
    }
}
