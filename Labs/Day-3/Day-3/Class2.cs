using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class2
    {
        /// <summary>
        /// Type of parameters we have in function
        /// 1.Named parameter
        /// 2.Optional parameter
        /// 3.Default parameter
        /// </summary>
        /// <param name="args"></param>
        static void Main3(string[] args)
        {
            sum(10,30);
            Console.WriteLine("======================");
            int x = 10;

            sumNames(c:1,b:x,a:10);
        }

        static void sum(int a,int b,int c=20)
        {
            Console.WriteLine(a+b);
        }
        static void sumNames(int a,int b,int c)
        {
            Console.WriteLine("a= "+a);
            Console.WriteLine("b= " +b);
        }
    }
}
