using hotel_management_api.Common.Enum;

namespace hotel_management_api.Models
{
    public class Bill : BaseModel
    {
        public int Id { get; set; }
        public int BookingId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public double TotalPrice { get; set; }
    }
}
