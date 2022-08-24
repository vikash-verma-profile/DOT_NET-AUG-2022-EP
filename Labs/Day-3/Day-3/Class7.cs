using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class7
    {
        int a;
        public Class7()
        {
            Console.WriteLine("I am default constructor");
            Console.WriteLine(a);
        }
        public Class7(int _a)
        {
            a=_a;
            Console.WriteLine("I am parameterized a="+a);
        }
        ~Class7()
        {

        }
        public static void Main()
        {
            Class7 obj = new Class7();
            Class7 obj1 = new Class7(1);
        }

        /*
         * abstract
         * selaed
         * virtual
         * operator
         * static
         * override
         */
    }
}
