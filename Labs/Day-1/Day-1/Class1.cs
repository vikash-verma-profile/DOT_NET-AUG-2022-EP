using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Class1
    {

        static void swap(ref int a, ref int b)
        {
            int c;
            c = a;
            a = b;
            b = c;
            Console.WriteLine("Value of a and b in swapping a=" + a +" b= "+b);
        }
        public static void Main3()
        {

            int a = 10, b = 20;
            swap(ref a,ref b);
            Console.WriteLine("after swaping a="+a+" b="+b);
        }
    }
}
