using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Salary { get; set; }
        public int? DepId { get; set; }
    }
}
