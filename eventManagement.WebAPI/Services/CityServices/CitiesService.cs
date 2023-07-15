using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Services.CityServices
{
    public class CitiesService : BaseService<City, CitySearchRequest, Cities>
    {
        public CitiesService(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<City> Get(CitySearchRequest search)
        {
            var query = _context.Set<Cities>().AsQueryable();

            if (search?.CountryId.HasValue == true)
            {
                query = query.Where(x => x.CountryId == search.CountryId);
            }

            var list = query.ToList();

            return _mapper.Map<List<City>>(list);
        }
    }
}
