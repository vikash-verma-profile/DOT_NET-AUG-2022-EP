using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Class2
    {
        static void Main2(string[] args)
        {
            /*int a = 10, b = 20;
               int sum = a + b;
               Console.WriteLine("sum of two number is "+sum);
            */

            //calling a function
            sum(30,20);
        }
        /// <summary>
        /// this function will add 2 values
        /// Defining a method in a class
        /// </summary>
        static void sum(int a,int b)
        {
            //int a = 10, b = 20;
            int sum = a + b;
            Console.WriteLine("sum of two number is " + sum);
        }
    }
}
