namespace BikeStores.Dto
{
    public class ProductsDto
    {
        public string ProductName { get; set; }
        public short ModelYear { get; set; }
        public decimal ListPrice { get; set; }

        public int BrandId { get; set; }
        public int CategoryId { get; set; }

        public string BrandName { get; set; }
        public string CategoryName { get; set; }
    }
}
