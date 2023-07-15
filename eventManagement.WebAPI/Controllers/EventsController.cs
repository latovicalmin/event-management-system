using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using eventManagement.WebAPI.Services;
using eventManagement.WebAPI.Services.UserServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    public class EventsController : BaseCRUDController<Event, EventSearchRequest, EventUpsertRequest, EventUpsertRequest>
    {
        private readonly IEventsService _service;

        public EventsController(ICRUDService<Event, EventSearchRequest, EventUpsertRequest, EventUpsertRequest> service, IEventsService eventsService) : base(service)
        {
            _service = eventsService;
        }

        [HttpGet("GetRecommendedById/{id}")]
        public List<Model.Event> GetRecommendedById(int id){
            return _service.GetRecommendedById(id);
        }
    }
}