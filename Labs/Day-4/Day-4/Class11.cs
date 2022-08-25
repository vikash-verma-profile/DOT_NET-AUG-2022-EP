using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// function or Method overloading
    /// </summary>
    /// 
    class OverloadingFunction
    {
        public void Sum(int a,int b)
        {
            Console.WriteLine("Sum is "+a+"+" + b +"=" + (a+b));
        }
        public void Sum(double a,double b)
        {
            Console.WriteLine("Sum is " + a + "+" + b + "=" + (a + b));
        }
        public void Sum(int a,int b,int c)
        {
            Console.WriteLine("Sum is " + a + "+" + b + "+" + c+"=" + (a + b+c));
        }
    }
    class Class11
    {
        public static void Main12()
        {
            OverloadingFunction ob = new OverloadingFunction();
            ob.Sum(1,2);
            ob.Sum(1, 2,3);
            ob.Sum(1.35, 2.789);

        }
    }
}
