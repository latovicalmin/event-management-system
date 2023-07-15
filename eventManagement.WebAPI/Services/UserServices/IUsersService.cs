using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eventManagement.Model;
using eventManagement.Model.Requests;
using eventManagement.WebAPI.Database;

namespace eventManagement.WebAPI.Services.UserServices
{
    public interface IUsersService
    {
        List<User> Get(UserSearchRequest request);
        User GetById(int id);
        User Insert(UserInsertRequest request);
        User Update(int id, UserInsertRequest request);
        User Authenticate(string username, string pass);
    }
}
