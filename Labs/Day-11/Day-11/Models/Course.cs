using System;
using System.Collections.Generic;

#nullable disable

namespace Day_11.Models
{
    public partial class Course
    {
        public Course()
        {
            CourseSubjects = new HashSet<CourseSubject>();
            Students = new HashSet<Student>();
        }

        public int Id { get; set; }
        public string CourseName { get; set; }

        public virtual ICollection<CourseSubject> CourseSubjects { get; set; }
        public virtual ICollection<Student> Students { get; set; }
    }
}
