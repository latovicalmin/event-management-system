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
    public class RolesController : BaseController<Role, object>
    {
        public RolesController(IService<Role, object> service) : base(service)
        {
        }
    }
}