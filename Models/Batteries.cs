using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Batteries
    {
        public long Id { get; set; }
        public long? BuildingId { get; set; }
        public string ProjectType { get; set; }
        public string Status { get; set; }
        public long? EmployeeId { get; set; }
        public DateTime? StartupDate { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public byte[] OperationCertificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
