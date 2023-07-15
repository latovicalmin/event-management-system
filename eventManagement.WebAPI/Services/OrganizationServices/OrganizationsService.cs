using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Services.OrganizationServices
{
    public class OrganizationsService : BaseCRUDService<Organization, OrganizationsSearchRequest, Organizations, OrganizationUpsertRequest, OrganizationUpsertRequest>
    {
        public OrganizationsService(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Organization> Get(OrganizationsSearchRequest search)
        {
            var query = _context.Set<Organizations>().AsQueryable();

            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().StartsWith(search.Name.ToLower()));
            }

            var list = query.ToList();

            return _mapper.Map<List<Organization>>(list);
        }
    }
}
