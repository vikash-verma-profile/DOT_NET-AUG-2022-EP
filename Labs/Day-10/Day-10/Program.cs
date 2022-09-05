using Day_10.Models;
using System;

namespace Day_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName;
            Console.WriteLine("Please enter student name");
            studentName=Console.ReadLine();
            //create an object of db context
            EmployeeDbContext db = new EmployeeDbContext();
            //create an object of student table
            TblStudent tblStudent = new TblStudent();
            tblStudent.StudentName = studentName;

            //add this to database
            db.TblStudents.Add(tblStudent);
            db.SaveChanges();


            Console.WriteLine("record added to db");
        }
    }
}
