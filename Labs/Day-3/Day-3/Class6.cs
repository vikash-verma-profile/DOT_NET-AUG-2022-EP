using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    /// <summary>
    /// Constructors
    /// Destructors
    /// Methods
    /// Properties
    /// Indexers
    /// Overloaded operators
    /// </summary>
    class Student
    {
        //fields are member variables
        //by default all member of a class are internal 
        public int rollno;
        public string name;
        public string gender;
    }
    class Class6
    {
        public static void Main()
        {
            Student student = new Student();

            Console.WriteLine("Please enter student rollno");
            student.rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student name");
            student.name = Console.ReadLine();
            Console.WriteLine("Please enter student gender");
            student.gender = Console.ReadLine();
            Console.WriteLine("============Student Details============");
            Console.WriteLine(student.rollno);
            Console.WriteLine(student.name);
            Console.WriteLine(student.gender);
        }
    }
}
