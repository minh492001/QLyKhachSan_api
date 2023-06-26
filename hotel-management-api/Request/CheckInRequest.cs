using hotel_management_api.Common.Enum;

namespace hotel_management_api.Request
{
    public class CheckInRequest
    {
        public int BookingId { get; set; }
        public string CitizenIdentification { get; set; }
    }
}
