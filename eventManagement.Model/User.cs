using System;
using System.Collections.Generic;
using System.Text;

namespace eventManagement.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public bool Active { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; } = null;

        public string Name
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }
    }
}
