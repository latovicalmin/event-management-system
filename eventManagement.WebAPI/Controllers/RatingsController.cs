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
    public class RatingsController : BaseCRUDController<Rating, RatingSearchRequest, RatingUpsertRequest, RatingUpsertRequest>
    {
        public RatingsController(ICRUDService<Rating, RatingSearchRequest, RatingUpsertRequest, RatingUpsertRequest> service) : base(service)
        {
        }
    }
}