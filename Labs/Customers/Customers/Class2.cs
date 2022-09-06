using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Customers
{
    /// <summary>
    /// 
    /// </summary>
    class Class2
    {
        //take
        //order
        //where
        //skip
        //join
        //group
        //distinct
        //contain
        public static void Main()
        {
            EmployeeDbContext db = new EmployeeDbContext();
            //var list = db.TblStudents.Select(x => new { x.Id ,x.StudentName});

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item.Id + " | " + item.StudentName);
            //}

            // IEnumerable<IGrouping<string,TblEmployee>>
            // var list = db.TblEmployees.GroupBy(x => x.EmployeeName, x=>x.Surnama).Select(x => new { EmployeeName=x.Key ,Counts=x.Count()});
            var list = db.TblEmployees.GroupBy(x => new { x.EmployeeName, x.Surnama }).Select(x => new { EmployeeName = x.Key.EmployeeName, Surnama= x.Key.Surnama });

            foreach (var item in list)
            {
                //Console.WriteLine(item.EmployeeName);
                //Console.WriteLine(item.Surnama);
                Console.WriteLine(item.EmployeeName + " | " + item.Surnama);
            }
        }
    }
}
