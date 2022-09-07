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
            //var data = db.Students.Join(db.Courses, x => x.CourseId, y => y.Id, (x, y) => new { Id=x.Id,firstName=x.Firstname,lastName=x.Lastname,CourseName=y.CourseName});
            var data = db.Students.Join(db.Courses, x => x.CourseId, y => y.Id, (x, y) => new { x,y }).Join(db.CourseSubjects,z=>z.y.Id,c=>c.CourseId,(z,c)=>new { Id = z.x.Id, firstName = z.x.Firstname, lastName = z.x.Lastname, CourseName = z.y.CourseName,Subject=c.SubjectName });
            Console.WriteLine("ID | FirstName | LastName | CourseName | SubjectName");
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.firstName + " | " + item.lastName + " | " + item.CourseName+ " | " + item.Subject);
            }
        }
    }
}
