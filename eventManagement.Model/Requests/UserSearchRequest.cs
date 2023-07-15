using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class UserSearchRequest
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RoleId { get; set; }
    }
}
