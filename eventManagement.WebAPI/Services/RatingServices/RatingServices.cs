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
    public class RatingServices : BaseCRUDService<Model.Rating, RatingSearchRequest, Database.Ratings, RatingUpsertRequest, RatingUpsertRequest>
    {
        public RatingServices(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Rating> Get(RatingSearchRequest search)
        {
            var query = _context.Set<Database.Ratings>().AsQueryable();

            if (search.EventId.HasValue && search.UserId.HasValue)
            {
                query = query.Where(x => x.EventId == search.EventId && x.UserId == search.UserId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Rating>>(list);
        }
    }
}
