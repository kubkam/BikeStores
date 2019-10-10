using System;
using System.Collections.Generic;

namespace BikeStores.Dto
{
    public class OrdersDto
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public byte OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; set; }
        public int StoreId { get; set; }
        public int StaffId { get; set; }

        public virtual CustomersDto Customer { get; set; }
        public virtual StaffsDto Staff { get; set; }
        public virtual StoresDto Store { get; set; }
    }
}
