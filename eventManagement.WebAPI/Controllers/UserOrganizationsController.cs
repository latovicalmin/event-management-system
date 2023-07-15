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
    public class UserOrganizationsController : BaseController<UserOrganizations, object>
    {
        public UserOrganizationsController(IService<UserOrganizations, object> service) : base(service)
        {
        }
    }
}