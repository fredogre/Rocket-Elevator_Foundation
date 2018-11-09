using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Quotes
    {
        public long Id { get; set; }
        public string ProjectType { get; set; }
        public string ProductType { get; set; }
        public int? NbOfUnits { get; set; }
        public int? NbOfFloors { get; set; }
        public int? NbOfBasements { get; set; }
        public int? NbOfParkings { get; set; }
        public int? NbOfElevators { get; set; }
        public int? MaxOccupants { get; set; }
        public int? BusinessHours { get; set; }
        public int? Nbshaft { get; set; }
        public int? Unitcost { get; set; }
        public int? Installcost { get; set; }
        public int? Totalcost { get; set; }
        public int? ContactId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
