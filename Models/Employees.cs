using System;
using System.Collections.Generic;

namespace RocketApi.Models
{
    public partial class Employees
    {
        public long Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Function { get; set; }
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public long? UserId { get; set; }
        public int? EmployeeId { get; set; }
    }
}
