using AutoMapper;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using eventManagement.WebAPI.Services.UserServices;
using eventManagement.WebAPI.Utils;

namespace eventManagement.WebAPI.Services.EventServices
{
    public class EventsService : BaseCRUDService<Event, EventSearchRequest, Events, EventUpsertRequest, EventUpsertRequest>, IEventsService
    {
        public EventsService(eventsContext context, IMapper mapper) : base(context, mapper)
        {
        }

        public override List<Event> Get(EventSearchRequest search)
        {
            var query = _context.Set<Events>()
                .Include("Organization")
                .Include("Category")
                .Include("City")
                .Include("Speakers.User")
                .Include("Participants.User")
                .AsQueryable();

            if (search?.OrganizationId.HasValue == true)
            {
                query = query.Where(x => x.OrganizationId == search.OrganizationId);
            }

            if (search?.CategoryId.HasValue == true)
            {
                query = query.Where(x => x.CategoryId == search.CategoryId);
            }

            if (!String.IsNullOrEmpty(search.Name))
            {
                query = query.Where(x => x.Name.ToLower().StartsWith(search.Name.ToLower()));
            }

            if (search.DateFrom.HasValue == true)
            {
                query = query.Where(x => x.DateTime >= search.DateFrom);
            }

            if (search.DateTo.HasValue == true)
            {
                query = query.Where(x => x.DateTime <= search.DateTo);
            }

            if (search.UserId.HasValue)
            {
                query = query.Where(x => x.Speakers.Any(s => s.UserId == search.UserId) || (x.Participants.Any(p => p.UserId == search.UserId)));
            }
            query = query.OrderBy(x => x.CreatedAt);

            var list = query.ToList();

            return _mapper.Map<List<Event>>(list);
        }

        public override Event Update(int id, EventUpsertRequest request)
        {
            var entity = _context.Events.Include("Speakers.User").Where(x => x.EventId == id).FirstOrDefault();

            _context.Events.Attach(entity);
            _context.Events.Update(entity);

            var existingSpeakers = entity.Speakers.Where(x => x.EventId == id);

            foreach (var speaker in existingSpeakers)
            {
                if (!request.SpeakerIDs.Contains(speaker.UserId))
                {
                    _context.Speakers.Remove(speaker);
                }
            }

            foreach (var speaker in request.SpeakerIDs)
            {
                Database.Speakers existingSpeaker = entity.Speakers.Where(x => x.UserId == (int)speaker).FirstOrDefault();
                if (existingSpeaker == null)
                {
                    _context.Speakers.Add(new Database.Speakers()
                    {
                        UserId = speaker,
                        EventId = entity.EventId
                    });
                }
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Event>(entity);
        }

        public override Event GetById(int id)
        {
            var entity = _context.Set<Events>()
                .Include("Organization")
                .Include("Category")
                .Include("City.Country")
                .Include("Speakers.User")
                .Include("Participants.User")
                .AsQueryable()
                .Where(x => x.EventId == id)
                .FirstOrDefault();

            return _mapper.Map<Event>(entity);
        }

        public List<Event> GetRecommendedById(int id)
        {
            Recommendation recommendation = new Recommendation(_context, _mapper);
            var recomList = recommendation.GetSimilarEvents(id);
            return recomList;
        }
    }
}
