﻿using AutoMapper;
using AutoMapper.Configuration;
using hotel_management_api.Common;
using hotel_management_api.Controllers;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Request;
using hotel_management_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace hotel_management_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserAuthenticateController : BaseApiController<UserAuthenticateController>
    {
        private readonly UserAuthenticateService _userAuthenticateService;
        public UserAuthenticateController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _userAuthenticateService = new UserAuthenticateService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [AllowAnonymous]
        [Route("UserLogin")]
        public MessageData UserLogin(UserLoginRequest userLoginRequest)
        {
            try
            {
                var res = _userAuthenticateService.UserLogin(userLoginRequest);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
