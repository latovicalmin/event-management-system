using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using eventManagement.WebAPI.Services.UserServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUsersService _service;
        public UsersController(IUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<List<User>> Get([FromQuery]UserSearchRequest request)
        {
            return _service.Get(request);
        }


        [HttpGet("{id}")]
        public ActionResult<User> GetById(int id)
        {
            return _service.GetById(id);
        }

        [HttpPost]
        public User Insert(UserInsertRequest request)
        {
            return _service.Insert(request);
        }

        [Authorize(Roles = "Administrator")]
        [HttpPut("{id}")]
        public User Update(int id, UserInsertRequest request)
        {
            return _service.Update(id, request);
        }
    }
}