using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class1
    {
        public static void Main2()
        {
            bool flag = true;
            int Number1=0, Number2=0;
            while (flag)
            {
                Console.WriteLine("Enter your choice \n 1.Add \n 2.Sub \n 3.Divide \n 4.Multiplication \n 5.Exit");
                int Choice = Convert.ToInt32(Console.ReadLine());
                if (Choice < 5)
                {
                    Console.WriteLine("Please enter value of Number 1");
                    Number1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter value of Number 2");
                    Number2 = Convert.ToInt32(Console.ReadLine());
                }
                Calculator(Choice, Number1, Number2,ref flag);
            }
            Console.WriteLine("Please come again!!!");
        }
        static void Calculator(int Choice, int Number1, int Number2,ref bool flag)
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
                case 5:
                    flag = false;
                    break;
                default:
                    Console.WriteLine("Please enter a valid input");
                    break;
            }
        }
    }
}
