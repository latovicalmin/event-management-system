using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eventManagement.Model.Requests
{
    public class OrganizationUpsertRequest
    {
        [Required]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }
        public byte[] Logo { get; set; }
        public byte[] LogoThumbnail { get; set; }
    }
}
