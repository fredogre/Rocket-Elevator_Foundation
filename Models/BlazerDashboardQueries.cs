using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class BlazerDashboardQueries
    {
        public long Id { get; set; }
        public long? DashboardId { get; set; }
        public long? QueryId { get; set; }
        public int? Position { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
