using System;
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
    public class CategoriesController : BaseCRUDController<Category, CategorySearchRequest, CategoryUpsertRequest, CategoryUpsertRequest>
    {
        public CategoriesController(ICRUDService<Category, CategorySearchRequest, CategoryUpsertRequest, CategoryUpsertRequest> service) : base(service)
        {
        }
    }
}