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
    public class StatisticController : BaseApiController<BookingController>
    {
        private readonly StatisticService _statisticService;
        public StatisticController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _statisticService = new StatisticService(apiConfig, databaseContext, mapper);
        }

        [HttpGet]
        [Authorize(Roles = "Accountant, Manager")]
        [Route("StatisticBill")]
        public MessageData StatisticBill(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var res = _statisticService.StatisticBill(dateFrom, dateTo);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
