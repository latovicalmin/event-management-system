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
    public class EventCategoriesController : BaseController<Model.EventCategories, object>
    {
        public EventCategoriesController(IService<Model.EventCategories, object> service) : base(service)
        {
        }
    }
}