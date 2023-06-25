using hotel_management_api.Common.Enum;

namespace hotel_management_api.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? NumberPhone { get; set; }
        public string? CitizenIdentification { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int NumberBooking { get; set; }
        public CustomerTypeEnum CustomerType { get; set; }
    }
}
