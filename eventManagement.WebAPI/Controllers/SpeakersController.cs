using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    public class SpeakersController : BaseController<Speakers, object>
    {
        public SpeakersController(IService<Speakers, object> service) : base(service)
        {
        }
    }
}