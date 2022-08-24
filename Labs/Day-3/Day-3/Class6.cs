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

        //it should have name same as class
        //it cannot have any return-type
        //we can have parameters and access modifiers

        //Default Constructor
        //Parameterized Constructor

        //Copy Constructor
        //Private Constructor
        //Static Constructor
        public Student(int _rollno,string _name,string _gender)
        {
            rollno = _rollno;
            name = _name;
            gender = _gender;
        }

        //Destructor
        ~Student()
        {

        }
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
        public static void Main7()
        {
            Student student = new Student(101,"Vikash Verma","Male");
            //student.getData();
            student.showData();
          
        }
    }
}
