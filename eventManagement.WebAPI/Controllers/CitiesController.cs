﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    public class CitiesController : BaseController<City, CitySearchRequest>
    {
        public CitiesController(IService<City, CitySearchRequest> service) : base(service)
        {
        }
    }
}