using System;

namespace Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter student Name");
            string studentName = Console.ReadLine();

            EmployeeDbContext db = new EmployeeDbContext();
            //Create an object of the class that is replica of db table
            TblStudent tblStudent = new TblStudent();
            tblStudent.StudentName = studentName;
            db.TblStudents.Add(tblStudent);
            //save collection to database whatever we have updated
            db.SaveChanges();
            Console.WriteLine("db record added successfully");
            
        }
    }
}
