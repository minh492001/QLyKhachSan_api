using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using hotel_management_api.Common;
using hotel_management_api.Common.Enum;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Models;
using hotel_management_api.Repositories;
using hotel_management_api.Request;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace hotel_management_api.Services
{
    public class BookingService
    {
        private readonly HotelRoomRepository _hotelRoomRepository;
        private readonly BookingRepository _bookingRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly BillRepository _billRepository;
        private readonly IMapper _mapper;
        public BookingService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
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
        public Booking BookRoom(int userId, BookRoomRequest request)
        {
            try
            {
                var newBooking = _mapper.Map<Booking>(request);
                var hotelRoom = _hotelRoomRepository.FindOrFail(newBooking.HotelRoomId);
                if (hotelRoom == null)
                {
                    throw new Exception("Hotel room does not exist!");
                }

                if (hotelRoom.RoomStatus != RoomStatusEnum.Vacant)
                {
                    throw new Exception("This room is occupied!");
                }

                // Save customer information
                var customer = _customerRepository.FindByCondition(row => row.CitizenIdentification == request.NumberPhone).FirstOrDefault();
                if (customer == null)
                {
                    customer = new Customer()
                    {
                        Name = request.Name,
                        CustomerType = CustomerTypeEnum.New,
                        NumberBooking = 1,
                        NumberPhone = request.NumberPhone
                    };
                    _customerRepository.Create(customer);
                    _customerRepository.SaveChange();
                }
                else
                {
                    customer.NumberPhone = request.NumberPhone;
                    customer.NumberBooking++;
                    _customerRepository.UpdateByEntity(customer);
                    _customerRepository.SaveChange();
                }

                //Update hotelRoom Status
                hotelRoom.RoomStatus = RoomStatusEnum.Reserve;
                _hotelRoomRepository.UpdateByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();

                newBooking.UserCreateId = userId;
                newBooking.Status = BookingStatusEnum.Reserve;
                newBooking.CustomerId = customer.Id;
                newBooking.ReservationTime = DateTime.Now;

                _bookingRepository.Create(newBooking);
                _bookingRepository.SaveChange();

                return newBooking;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Rent room
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        public Booking RentRoom(int userId, RentRoomRequest request)
        {
            try
            {
                var newBooking = _mapper.Map<Booking>(request);
                newBooking.ReservationTime = DateTime.Now;
                newBooking.CheckinTime = DateTime.Now;
                var hotelRoom = _hotelRoomRepository.FindOrFail(newBooking.HotelRoomId);
                if (hotelRoom == null)
                {
                    throw new Exception("Hotel room does not exist!");
                }

                if (hotelRoom.RoomStatus != RoomStatusEnum.Vacant)
                {
                    throw new Exception("This room is occupied!");
                }

                // Save customer information
                var customer = _customerRepository.FindByCondition(row => row.CitizenIdentification == request.CitizenIdentification).FirstOrDefault();
                if (customer == null)
                {
                    customer = new Customer()
                    {
                        Name = request.Name,
                        CitizenIdentification = request.CitizenIdentification,
                        CustomerType = CustomerTypeEnum.New,
                        NumberBooking = 1
                    };
                    _customerRepository.Create(customer);
                    _customerRepository.SaveChange();
                }
                else
                {
                    customer.NumberBooking++;
                    _customerRepository.UpdateByEntity(customer);
                    _customerRepository.SaveChange();
                }

                //Update hotelRoom Status
                hotelRoom.RoomStatus = RoomStatusEnum.Staying;
                _hotelRoomRepository.UpdateByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();

                newBooking.UserCreateId = userId;
                newBooking.Status = BookingStatusEnum.Staying;
                newBooking.CustomerId = customer.Id;

                _bookingRepository.Create(newBooking);
                _bookingRepository.SaveChange();

                return newBooking;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Check In
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Booking CheckIn(CheckInRequest request)
        {
            try
            {
                var booking = _bookingRepository.FindOrFail(request.BookingId);
                if(booking == null)
                {
                    throw new Exception("Booking does not exits!");
                }
                if(booking.Status != BookingStatusEnum.Reserve)
                {
                    throw new Exception("The room is already in use!");
                }

                // Update status hotel room
                var hotelRoom = _hotelRoomRepository.FindOrFail(booking.HotelRoomId);
                hotelRoom.RoomStatus = RoomStatusEnum.Staying;
                _hotelRoomRepository.UpdateByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();

                // update status booking
                booking.CheckinTime = DateTime.Now;
                booking.Status = BookingStatusEnum.Staying;
                _bookingRepository.UpdateByEntity(booking);
                _bookingRepository.SaveChange();

                // Update customer
                var customer = _customerRepository.FindOrFail(booking.CustomerId);
                customer.CitizenIdentification = request.CitizenIdentification;
                _customerRepository.UpdateByEntity(customer);
                _customerRepository.SaveChange();

                return booking;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Checkout
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public Bill CheckOut(CheckoutRequest request)
        {
            try
            {
                var booking = _bookingRepository.FindOrFail(request.BookingId);
                if (booking == null)
                {
                    throw new Exception("Booking does not exits!");
                }
                if (booking.Status != BookingStatusEnum.Staying)
                {
                    throw new Exception("The room is not Staying");
                }

                var hotelRoom = _hotelRoomRepository.FindOrFail(booking.HotelRoomId);
                hotelRoom.RoomStatus = RoomStatusEnum.Checkout;
                _hotelRoomRepository.UpdateByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();

                booking.CheckoutTime = DateTime.Now;
                booking.Status = BookingStatusEnum.Paid;
                _bookingRepository.UpdateByEntity(booking);
                _bookingRepository.SaveChange();

                var totalHours = (int)(booking.CheckoutTime - booking.CheckinTime).TotalHours + 1;
                var totalPrice = 200000.0;
                if(totalHours > 2)
                {
                    totalPrice += (totalHours - 2) * 20000;
                }

                if(hotelRoom.RoomType == RoomTypeEnum.DoubleRoom)
                {
                    totalPrice *= 1.5;
                }
                else if (hotelRoom.RoomType == RoomTypeEnum.VIPRoom)
                {
                    totalPrice *= 2.5;
                }

                var bill = new Bill()
                {
                    BookingId = booking.Id,
                    StartTime = booking.CheckinTime,
                    EndTime = booking.CheckoutTime,
                    TotalPrice = totalPrice
                };

                _billRepository.Create(bill);
                _billRepository.SaveChange();

                return bill;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public object CleanRoom(CleanRoomRequest request)
        {
            try
            {
                var hotelRoom = _hotelRoomRepository.FindOrFail(request.HotelRoomId);
                if (hotelRoom == null)
                {
                    throw new Exception("");
                }
                hotelRoom.RoomStatus = RoomStatusEnum.Vacant;
                _hotelRoomRepository.UpdateByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();

                return hotelRoom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public object GetBookingList(RoomStatusEnum status)
        {
            try
            {
                var query = this._hotelRoomRepository.FindByCondition(row => row.RoomStatus == status);
                var amount = query.Count();

                var hotelRoom = query.ToList();
                var hotelRoomPlanDtoList = hotelRoom.Select(row => _mapper.Map<HotelRoomPlanDto>(row)).ToList();
                foreach (var hotelRoomPlanDto in hotelRoomPlanDtoList)
                {
                    if (hotelRoomPlanDto.RoomStatus != RoomStatusEnum.Vacant)
                    {
                        var booking = _bookingRepository.FindAll().Where(row => row.HotelRoomId == hotelRoomPlanDto.Id).OrderByDescending(row => row.Id).FirstOrDefault();
                        if (booking != null)
                        {
                            hotelRoomPlanDto.BookingId = booking.Id;
                            hotelRoomPlanDto.CustomerId = booking.CustomerId;
                            hotelRoomPlanDto.UserCreateId = booking.UserCreateId;
                            hotelRoomPlanDto.ReservationTime = booking.ReservationTime;
                            hotelRoomPlanDto.CheckinTime = booking.CheckinTime;
                            hotelRoomPlanDto.CheckoutTime = booking.CheckoutTime;
                            hotelRoomPlanDto.Status = booking.Status;
                        }

                        var customer = _customerRepository.FindOrFail(hotelRoomPlanDto.CustomerId);
                        if (customer != null)
                        {
                            hotelRoomPlanDto.CustomerName = customer.Name;
                            hotelRoomPlanDto.CitizenIdentification = customer.CitizenIdentification;
                            hotelRoomPlanDto.NumberPhone = customer.NumberPhone;
                        }
                    }
                }

                return new
                {
                    data = hotelRoomPlanDtoList,
                    Amount = amount
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
