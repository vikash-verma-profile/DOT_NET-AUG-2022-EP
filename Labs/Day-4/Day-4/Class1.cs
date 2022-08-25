using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Employee
    {
        public int SomeValue;
        public void DisplayAge()
        {
            //local variable
            int age = 0;
            age = age + 35;
            Console.WriteLine("Employee age is "+age);
        }
    }
    class Class1
    {
        public static void Main2()
        {
            Employee obj = new Employee();
            obj.DisplayAge();
            obj.SomeValue = 20;
            Employee Obj2 = new Employee();
            Console.WriteLine(obj.SomeValue);
            Console.WriteLine(Obj2.SomeValue);
        }
    }
}
