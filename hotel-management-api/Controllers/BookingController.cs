using AutoMapper;
using hotel_management_api.Common;
using hotel_management_api.Common.Enum;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Request;
using hotel_management_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace hotel_management_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookingController : BaseApiController<BookingController>
    {
        private readonly BookingService _bookingService;
        public BookingController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _bookingService = new BookingService(apiConfig, databaseContext, mapper);
        }

        [HttpGet]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("GetBookingList")]
        public MessageData GetBookingList(RoomStatusEnum roomStatusEnum)
        {
            try
            {
                var res = _bookingService.GetBookingList(roomStatusEnum);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// book room
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("BookRoom")]
        public MessageData BookRoom(BookRoomRequest request)
        {
            try
            {
                var res = _bookingService.BookRoom(UserId, request);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Rent room
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("RentRoom")]
        public MessageData RentRoom(RentRoomRequest request)
        {
            try
            {
                var res = _bookingService.RentRoom(UserId, request);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Customer checkin
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("CheckIn")]
        public MessageData CheckIn(CheckInRequest request)
        {
            try
            {
                var res = _bookingService.CheckIn(request);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Customer Checkout
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("Checkout")]
        public MessageData Checkout(CheckoutRequest request)
        {
            try
            {
                var res = _bookingService.CheckOut(request);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Roles = "Receptionist, Manager")]
        [Route("CleanRoom")]
        public MessageData CleanRoom(CleanRoomRequest request)
        {
            try
            {
                var res = _bookingService.CleanRoom(request);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
