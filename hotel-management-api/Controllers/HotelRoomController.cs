using AutoMapper;
using hotel_management_api.Common;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hotel_management_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelRoomController : BaseApiController<HotelRoomController>
    {
        private readonly HotelRoomService _hotelRoomService;
        public HotelRoomController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _hotelRoomService = new HotelRoomService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Search user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize]
        [Route("GetRoomHotelPlan")]
        public MessageData GetRoomHotelPlan(int limit, int page)
        {
            try
            {
                var res = _hotelRoomService.GetHotelRoomPlan(limit, page);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
