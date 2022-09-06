using System;
using System.Collections.Generic;
using System.Linq;

namespace Customers
{
    class Program
    {
        static void Main1(string[] args)
        {
            EmployeeDbContext db = new EmployeeDbContext();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("==============================");
                Console.WriteLine("Please enter your choice \n 1.ADD record \n 2.Update Record \n 3.Delete \n 4.List \n 5.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("===============================");
                switch (choice)
                {
                    case 1:
                        AddRecord(db);
                        break;
                    case 2:
                        PrintRecords(db);
                        UpdateRecord(db);
                        break;
                    case 3:
                        PrintRecords(db);
                        DeleteRecord(db);
                        break;
                    case 4:
                        PrintRecords(db);
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

        public static void PrintRecords(EmployeeDbContext db)
        {
            Console.WriteLine("ID| Student Name");
            foreach (var item in db.TblStudents)
            {
                Console.WriteLine(item.Id + " | " + item.StudentName);
            }
        }

        public static void UpdateRecord(EmployeeDbContext db)
        {
            Console.WriteLine("Please select an Id to update");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the new name");
            string newName = Console.ReadLine();
            var studentObj = db.TblStudents.Where(x => x.Id == Id).FirstOrDefault();
            studentObj.StudentName = newName;
            db.TblStudents.Update(studentObj);
            db.SaveChanges();
            Console.WriteLine("Record is updated successfully");
        }

        public static void DeleteRecord(EmployeeDbContext db)
        {
            Console.WriteLine("Please select an Id to update");
            int Id = Convert.ToInt32(Console.ReadLine());
            var studentObj = db.TblStudents.Where(x => x.Id == Id).FirstOrDefault();
            db.TblStudents.Remove(studentObj);
            db.SaveChanges();
            Console.WriteLine("Record is deleted successfully");
        }
    }
}
