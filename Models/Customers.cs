using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Customers
    {
        public long Id { get; set; }
        public long? UserId { get; set; }
        public string Company { get; set; }
        public long? AddressId { get; set; }
        public string ContactName { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEmail { get; set; }
        public string CompanyDescription { get; set; }
        public string ServiceTechName { get; set; }
        public string ServiceTechPhone { get; set; }
        public string ServiceTechEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
