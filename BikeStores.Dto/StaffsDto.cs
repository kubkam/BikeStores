namespace BikeStores.Dto
{
    public class StaffsDto
    {
        public int StaffId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public byte Active { get; set; }
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }

        public virtual StaffsDto Manager { get; set; }
        public virtual StoresDto Store { get; set; }
    }
}
