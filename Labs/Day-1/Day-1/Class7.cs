using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Class7
    {
        public static void Main()
        {
            Console.WriteLine("Enter your choice \n 1.Add \n 2.Sub \n 3.Divide \n 4.Multiplication");
            int Choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value of Number 1");
            int Number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter value of Number 2");
            int Number2 = Convert.ToInt32(Console.ReadLine());
            Calculator(Choice,Number1,Number2);
        }
        static void Calculator(int Choice,int Number1,int Number2)
        {
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Sum of " + Number1 + "+" + Number2 + "=" + (Number1 + Number2));
                    break;
                case 2:
                    Console.WriteLine("Sum of " + Number1 + "-" + Number2 + "=" + (Number1 - Number2));
                    break;
                case 3:
                    Console.WriteLine("Sum of " + Number1 + "/" + Number2 + "=" + (Number1 / Number2));
                    break;
                case 4:
                    Console.WriteLine("Sum of " + Number1 + "*" + Number2 + "=" + (Number1 * Number2));
                    break;
            }
        }
    }
}
