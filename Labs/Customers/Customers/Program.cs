using System;
using System.Collections.Generic;
using System.Linq;

namespace Customers
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            bool flag=true;
            while (flag)
            {
                Console.WriteLine("Please enter your choice \n 1.ADD record \n 2.Update Record \n 3.Delete \n 4.List \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddRecord(db);
                        break;
                    case 2:
                        break;

                    case 3:
                        break;
                    case 4:
                        foreach (var item in ReadRecords(db))
                        {
                            Console.WriteLine(item.Id+":"+item.StudentName);
                        }
                        break;
                    case 5:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Pleas enter valid Input");
                        break;
                }
                if (!flag)
                    break;
            }
           
            
        }

        public static void AddRecord(EmployeeDbContext db) {
            Console.WriteLine("Please enter student Name");
            string studentName = Console.ReadLine();
            //Create an object of the class that is replica of db table
            TblStudent tblStudent = new TblStudent();
            tblStudent.StudentName = studentName;
            db.TblStudents.Add(tblStudent);
            //save collection to database whatever we have updated
            db.SaveChanges();
            Console.WriteLine("db record added successfully");
        }

        public static  List<TblStudent> ReadRecords(EmployeeDbContext db)
        {
            return db.TblStudents.ToList();
        }
    }
}
