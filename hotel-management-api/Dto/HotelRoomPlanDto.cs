using hotel_management_api.Common.Enum;

namespace hotel_management_api.Dto
{
    public class HotelRoomPlanDto
    {
        public int Id { get; set; }
        public string NoRoom { get; set; }
        public int Floor { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public int NumberBed { get; set; }
        public int Area { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public RoomStatusEnum RoomStatus { get; set; }
        public string Option { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        // booking
        public int BookingId { get; set; }
        public int CustomerId { get; set; }
        public int UserCreateId { get; set; }
        public DateTime ReservationTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public BookingStatusEnum Status { get; set; }

        // custom
        public string CustomerName { get; set; }
        public string CitizenIdentification { get; set; }
        public string NumberPhone { get; set; }

    }
}
