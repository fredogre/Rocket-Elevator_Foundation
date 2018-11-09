using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Contacts
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProjectName { get; set; }
        public string Location { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
