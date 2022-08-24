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
        int rollno;
        string name;
        string gender;

        public void getData()
        {
            Console.WriteLine("Please enter student rollno");
            rollno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter student name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter student gender");
            gender = Console.ReadLine();
        }
        public void showData()
        {
            Console.WriteLine("============Student Details============");
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(gender);
        }
    }
    class Class6
    {
        public static void Main()
        {
            Student student = new Student();
            student.getData();
            student.showData();
          
        }
    }
}
