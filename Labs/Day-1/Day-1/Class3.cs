using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Class3
    {
        /// <summary>
        /// Input from user
        /// </summary>
        public static void Main()
        {
            //string Name;
            //Console.WriteLine("Please enter your name");
            //Name = Console.ReadLine();
            //Console.WriteLine("Input from user is : "+Name);

            int Number1, Number2,Sum;

            Console.WriteLine("Please enter the value of Number 1");
            Number1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the value of Number 2");
            Number2 = Convert.ToInt32(Console.ReadLine());
            Sum = Number1 + Number2;
            Console.WriteLine("Sum of "+Number1+"+"+Number2+"= "+Sum);
        }
    }
}
