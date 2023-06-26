using hotel_management_api.Common.Enum;

namespace hotel_management_api.Request
{
    public class BookRoomRequest
    {
        public int HotelRoomId { get; set; }
        public string Name { get; set; }
        public string NumberPhone { get; set; }
    }
}
