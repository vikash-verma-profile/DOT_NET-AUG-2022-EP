using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{

    class A
    {
        public A()
        {
            Console.WriteLine("Hi I am A");
        }
    }
    class B:A
    {
        public B()
        {
            Console.WriteLine("Hi I am B");
        }
    }
    class C:B
    {
        public C()
        {
            Console.WriteLine("Hi I am C");
        }
    }
    class Class6
    {
        public static void Main()
        {
            C c = new C();
        }
      

    }
}
