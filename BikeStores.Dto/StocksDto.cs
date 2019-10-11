namespace BikeStores.Dto
{
    public class StocksDto
    {
        public int StoreId { get; set; }
        public int ProductId { get; set; }
        public int? Quantity { get; set; }

        public virtual ProductsDto Product { get; set; }
        public virtual StoresDto Store { get; set; }
    }
}
