using System;
using System.Collections.Generic;

namespace eventManagement.WebAPI.Database
{
    public partial class Users
    {
        public Users()
        {
            Comments = new HashSet<Comments>();
            Participants = new HashSet<Participants>();
            Ratings = new HashSet<Ratings>();
            Speakers = new HashSet<Speakers>();
            UserOrganizations = new HashSet<UserOrganizations>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<Comments> Comments { get; set; }
        public virtual ICollection<Participants> Participants { get; set; }
        public virtual ICollection<Ratings> Ratings { get; set; }
        public virtual ICollection<Speakers> Speakers { get; set; }
        public virtual ICollection<UserOrganizations> UserOrganizations { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
    }
}
