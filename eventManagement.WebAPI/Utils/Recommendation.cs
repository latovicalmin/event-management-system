using AutoMapper;
using eventManagement.Model;
using eventManagement.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eventManagement.WebAPI.Utils
{
    public class Recommendation
    {
        Dictionary<int, List<Ratings>> events = new Dictionary<int, List<Ratings>>();
        eventsContext _db;
        IMapper _mapper;

        public Recommendation(eventsContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public List<Event> GetSimilarEvents(int eventId)
        {
            LoadEvents(eventId);
            List<Ratings> ratingsSelectedEvent = _db.Ratings.Where(x => x.EventId == eventId).OrderBy(x => x.UserId).ToList();
            List<Ratings> commonRatings1 = new List<Ratings>();
            List<Ratings> commonRatings2 = new List<Ratings>();

            List<Event> recommended = new List<Event>();

            foreach (var eventElement in events)
            {
                foreach (var rating in ratingsSelectedEvent)
                {
                    if (eventElement.Value.Where(x => x.UserId == rating.UserId).Count() > 0)
                    {
                        commonRatings1.Add(rating);
                        commonRatings2.Add(eventElement.Value.Where(x => x.UserId == rating.UserId).First());
                    }
                }
                double similar = GetSimilarity(commonRatings1, commonRatings2);
                if (similar > 0.6)
                {
                    var entity = _db.Events.Find(eventElement.Key);
                    var mapped = _mapper.Map<Event>(entity);
                    recommended.Add(mapped);
                }

                commonRatings1.Clear();
                commonRatings2.Clear();
            }
            return recommended;
        }

        private void LoadEvents(int eventId)
        {
            var activeEvents = _db.Events.Where(x => x.EventId != eventId && x.DateTime > DateTime.Now).ToList();

            List<Ratings> ratingsList;

            foreach (var item in activeEvents)
            {
                ratingsList = _db.Ratings.Where(x => x.EventId == item.EventId).OrderBy(x => x.User).ToList();
                if (ratingsList.Count > 0)
                    events.Add(item.EventId, ratingsList);

            }
        }
        double GetSimilarity(List<Ratings> ratings1, List<Ratings> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
                return 0;

            decimal numerator = 0;
            decimal int1 = 0;
            decimal int2 = 0;

            for (int i = 0; i < ratings1.Count; i++)
            {
                numerator += ratings1[i].Value * ratings2[i].Value;
                int1 += ratings1[i].Value * ratings1[i].Value;
                int2 += ratings2[i].Value * ratings2[i].Value;
            }

            int1 = (decimal)Math.Sqrt((double)int1);
            int2 = (decimal)Math.Sqrt((double)int2);

            decimal denominator = int1 * int2;

            if (denominator != 0)
                return (double)numerator / (double)denominator;

            return 0;

        }
    }
}
