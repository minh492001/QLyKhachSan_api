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
    public class CustomerManagementController : BaseApiController<CustomerManagementController>
    {
        private readonly CustomerService _customerService;
        public CustomerManagementController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _customerService = new CustomerService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Search user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Manager")]
        [Route("Get")]
        public MessageData Get(int limit, int page, string? name)
        {
            try
            {
                var res = _customerService.GetCustomers(limit, page, name);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        [HttpGet]
        [Authorize(Roles = "Manager")]
        [Route("GetDetail")]
        public MessageData GetDetail(int id)
        {
            try
            {
                var res = _customerService.GetDetail(id);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
