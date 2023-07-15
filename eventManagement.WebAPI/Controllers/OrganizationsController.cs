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
    public class OrganizationsController : BaseCRUDController<Organization, OrganizationsSearchRequest, OrganizationUpsertRequest, OrganizationUpsertRequest>
    {
        public OrganizationsController(ICRUDService<Organization, OrganizationsSearchRequest, OrganizationUpsertRequest, OrganizationUpsertRequest> service) : base(service)
        {
        }
    }
}