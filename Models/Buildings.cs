using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Buildings
    {
        public long Id { get; set; }
        public long? CustomerId { get; set; }
        public long? AddressId { get; set; }
        public string AdministratorName { get; set; }
        public string AdministratorEmail { get; set; }
        public string AdministratorPhone { get; set; }
        public string TechnicianName { get; set; }
        public string TechnicianEmail { get; set; }
        public string TechnicianPhone { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
