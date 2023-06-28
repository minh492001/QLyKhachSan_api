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

namespace hotel_management_api.Services
{
    public class CustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly IMapper _mapper;
        public CustomerService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _customerRepository = new CustomerRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get user
        /// </summary>
        /// <returns></returns>
        public object GetCustomers(int limit, int page, string? name)
        {
            try
            {
                var query = this._customerRepository.FindAll();
                if (name != null)
                {
                    query = query.Where(row => row.Name.Contains(name));
                }
                query.Skip((page - 1) * limit).Take(limit);
                var total = query.Count();
                int tmpByInt = total / limit;
                double tmpByDouble = (double)total / (double)limit;
                int totalPage = 1;
                if(tmpByDouble > (double)tmpByInt)
                {
                    totalPage = tmpByInt + 1;
                }
                else
                {
                    totalPage = tmpByInt;
                }
                query = query.Skip((page - 1) * limit).Take(limit);
                var amount = query.Count();
                return new
                {
                    data = query.ToList(),
                    Amount = amount,
                    PageSize = limit,
                    Total = total,
                    TotalPage = totalPage,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// get detail
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object GetDetail(int id)
        {
            try
            {
                var model = _customerRepository.FindOrFail(id);
                if (model == null)
                {
                    throw new Exception("Customer does not exit!");
                }

                return model;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
