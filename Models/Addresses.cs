using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Addresses
    {
        public long Id { get; set; }
        public string AddressType { get; set; }
        public string Status { get; set; }
        public string Entity { get; set; }
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Postalcode { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string State { get; set; }
    }
}
