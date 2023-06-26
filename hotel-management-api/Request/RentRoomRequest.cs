using hotel_management_api.Common.Enum;

namespace hotel_management_api.Request
{
    public class RentRoomRequest
    {
        public int HotelRoomId { get; set; }
        public string Name { get; set; }
        public string CitizenIdentification { get; set; }
    }
}
