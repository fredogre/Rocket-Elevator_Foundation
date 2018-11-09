using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Leads
    {
        public long Id { get; set; }
        public string FullName { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ElevatorsDepartment { get; set; }
        public string Message { get; set; }
        public byte[] AttachedFile { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? CustomerId { get; set; }
    }
}
