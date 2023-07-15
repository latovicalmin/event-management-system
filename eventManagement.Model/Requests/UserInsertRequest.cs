using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class UserInsertRequest
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MinLength(2)]
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public bool Active { get; set; }
        public List<int> Roles { get; set; } = new List<int>();
    }
}
