using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{

    class A
    {
        //public A()
        //{
        //    Console.WriteLine("Hi I am A");
        //}

        public A(int a) {
            Console.WriteLine("Value of a IN A is "+a);
        }

    }
    class B:A
    {
        public B(int a):base(a)
        {
            Console.WriteLine("Value of a in B is " + a);
        }
    }
    class C:B
    {
        public C(int a):base(a)
        {
            Console.WriteLine("Value of a in C is " + a);
        }
    }
    class Class6
    {
        public static void Main()
        {
            C c = new C(1);
        }
      

    }
}
