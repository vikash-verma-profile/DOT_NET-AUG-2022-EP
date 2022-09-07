using Day_11.Models;
using System;
using System.Linq;

namespace Day_11
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoDBContext db = new DemoDBContext();
            var data = db.Students.Join(db.Courses, x => x.CourseId, y => y.Id, (x, y) => new { Id=x.Id,firstName=x.Firstname,lastName=x.Lastname,CourseName=y.CourseName});
            Console.WriteLine("ID | FirstName | LastName | CourseName");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.firstName + " | " + item.lastName + " | " + item.CourseName);
            }
        }
    }
}
