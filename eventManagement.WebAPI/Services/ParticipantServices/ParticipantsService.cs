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
    public class ParticipantsService : BaseCRUDService<Model.Participants, ParticipantSearchRequest, Database.Participants, ParticipantUpsertRequest, ParticipantUpsertRequest>
    {
        public ParticipantsService(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Model.Participants> Get(ParticipantSearchRequest search)
        {
            var query = _context.Set<Database.Participants>().AsQueryable();

            if (search.EventId.HasValue && search.UserId.HasValue)
            {
                query = query.Where(x => x.EventId == search.EventId && x.UserId == search.UserId);
            }

            var list = query.ToList();

            return _mapper.Map<List<Model.Participants>>(list);
        }
    }
}
