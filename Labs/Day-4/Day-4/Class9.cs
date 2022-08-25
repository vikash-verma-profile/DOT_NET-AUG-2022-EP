using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    interface IAAA
    {
        void print();
    }
    class Class9:IAAA
    {
        public void print()
        {
            Console.WriteLine("Hello");
        }
        public static void Main10()
        {
            Class9 c = new Class9();
            c.print();
        }
    }
}
