using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Anonymous types
    /// Anonymous Method
    /// </summary>
    /// 
    class Student
    {
       public int roll;
        public string Name;
    }
    class Class2
    {
        public static void Sample()
        {
            Console.WriteLine("Hi I am normal method");
        }
        public static void Main3()
        {
            Sample();

            //Normal class object
            Student s = new Student { Name = "Vikash", roll = 101 };
            //Anonymous Type
            var s1 = new
            {
                Name = "Vikash",
                roll = 101
            };

            var anyarray = new[] { new { name = "Vikash 1", roll = 101 } , 
                new { name = "Vikash 2", roll = 102 } , new { name = "Vikash 3", roll = 103 } };
            Console.WriteLine(s.Name);
            Console.WriteLine(s.roll);
            Console.WriteLine("===========================");
            Console.WriteLine(s1.Name);
            Console.WriteLine(s1.roll);

            Console.WriteLine("========================");
            foreach (var item in anyarray)
            {
                Console.WriteLine(item.name);
                Console.WriteLine(item.roll);
            }
        }
    }
}
