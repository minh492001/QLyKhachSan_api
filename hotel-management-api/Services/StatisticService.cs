using AutoMapper;
using hotel_management_api.Common;
using hotel_management_api.Database;
using hotel_management_api.Repositories;
using hotel_management_api.Request;

namespace hotel_management_api.Services
{
    public class StatisticService
    {
        private readonly HotelRoomRepository _hotelRoomRepository;
        private readonly BookingRepository _bookingRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly BillRepository _billRepository;
        private readonly IMapper _mapper;
        public StatisticService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _hotelRoomRepository = new HotelRoomRepository(apiOption, databaseContext, mapper);
            _bookingRepository = new BookingRepository(apiOption, databaseContext, mapper);
            _customerRepository = new CustomerRepository(apiOption, databaseContext, mapper);
            _billRepository = new BillRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Book room
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public object StatisticBill(DateTime dateFrom, DateTime dateTo)
        {
            try
            {
                var billList = _billRepository.FindByCondition(row => row.CreatedDate >= dateFrom && row.CreatedDate <= dateTo).ToList();
                var totalMoney = billList.Sum(row => row.TotalPrice);

                return new
                {
                    billList = billList,
                    totalMoney = totalMoney
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
