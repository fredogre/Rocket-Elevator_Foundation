using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Columns
    {
        public long Id { get; set; }
        public long? BatteryId { get; set; }
        public string ProjectType { get; set; }
        public int? NumberOfFloors { get; set; }
        public string Status { get; set; }
        public string Information { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
