using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;

namespace eventManagement.WebAPI.Services.UserServices
{
    public interface IEventsService
    {
        List<Event> GetRecommendedById(int id);
    }
}
