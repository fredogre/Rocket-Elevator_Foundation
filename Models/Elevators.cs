using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Elevators
    {
        public long Id { get; set; }
        public long? ColumnId { get; set; }
        public string SerialNumber { get; set; }
        public string Model { get; set; }
        public string ProjectType { get; set; }
        public string Status { get; set; }
        public DateTime? StartupDate { get; set; }
        public DateTime? LastInspectionDate { get; set; }
        public byte[] InspectionCertificate { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
