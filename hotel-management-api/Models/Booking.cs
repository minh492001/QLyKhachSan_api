using hotel_management_api.Common.Enum;

namespace hotel_management_api.Models
{
    public class Booking : BaseModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int HotelRoomId { get; set; }
        public int UserCreateId { get; set; }
        public DateTime ReservationTime { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public BookingStatusEnum Status { get; set; }
    }
}
