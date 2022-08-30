using System;
using System.Collections;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Collections
    /// Adding and inseting items to a collection
    /// 
    /// Non-generic   generic
    /// </summary>
    /// 
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
    }
    class Class2
    {
        public static void Main3()
        {
            ArrayList al = new ArrayList();

            Employee emp = new Employee();

            emp.EmployeeId = 101;
            emp.EmployeeName = "Vikash";
            al.Add(emp);

            foreach (Employee item in al)
            {
                Console.WriteLine(item.EmployeeId);
                Console.WriteLine(item.EmployeeName);
            }

            /*
            al.Add(s);
           // string str = "Vikash Vermna";
            int x = 7;
            int x1 = 89;
            int x2 = 1;
            int x3 = 71;
            // DateTime d = DateTime.Now;

           // al.Add(str);
            al.Add(x);
            al.Add(x1);
            al.Add(x2);
            al.Add(x3);
            //  al.Add(d);
            //al.Clear();
            //al.Remove(str);
            al.Sort();

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }

            */
        }
    }
}
