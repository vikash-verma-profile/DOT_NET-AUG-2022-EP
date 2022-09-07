using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class CourseSubject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }
        public int? CourseId { get; set; }

        public virtual Course Course { get; set; }
    }
}
