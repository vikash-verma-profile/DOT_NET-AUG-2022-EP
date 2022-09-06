using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Customers
{
    class Class1
    {
        public static void Main()
        {
            EmployeeDbContext db = new EmployeeDbContext();
            //order by clause in linq
            var data = db.TblStudents.OrderByDescending(x=>x.Id);
            //var smple = db.TblStudents.Where(x => x.Id == 1);

            //TblStudent s = smple;

            IQueryable<TblStudent> list = db.TblStudents.Where(x => x.StudentName.Equals("Vikash"));
            list=list.Take(2);


            IEnumerable<TblStudent> Ilist = db.TblStudents.Where(x => x.StudentName.Equals("Vikash"));
            list = list.Take(2);
            foreach (var item in data)
            {
                Console.WriteLine(item.Id + " | " + item.StudentName);
            }
        }
    }
}
