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
    public class UserRolesController : BaseController<Model.UserRoles, object>
    {
        public UserRolesController(IService<Model.UserRoles, object> service) : base(service)
        {
        }
    }
}