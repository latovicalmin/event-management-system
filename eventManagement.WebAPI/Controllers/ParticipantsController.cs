using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using eventManagement.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eventManagement.WebAPI.Controllers
{
    public class ParticipantsController : BaseCRUDController<Model.Participants, ParticipantSearchRequest, ParticipantUpsertRequest, ParticipantUpsertRequest>
    {
        public ParticipantsController(ICRUDService<Model.Participants, ParticipantSearchRequest, ParticipantUpsertRequest, ParticipantUpsertRequest> service) : base(service)
        {
        }
    }
}