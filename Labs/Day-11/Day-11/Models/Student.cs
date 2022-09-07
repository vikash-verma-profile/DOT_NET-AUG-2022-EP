using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public int? CourseId { get; set; }
        public int? Age { get; set; }
        public string StudentId { get; set; }

        public virtual Course Course { get; set; }
    }
}
