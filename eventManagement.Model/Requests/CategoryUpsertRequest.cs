using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class CategoryUpsertRequest
    {
        [Required]
        [MaxLength(100)]
        [MinLength(2)]
        public string Name { get; set; }
    }
}
