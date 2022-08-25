using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// private
    /// protected
    /// internal 
    /// public
    /// </summary>
    /// 

    class A
    {
        internal int a;
        private int a1;
        public int a2;
        protected int a3;
        public A()
        {

        }
    }

    class B:A
    {
        public void Display()
        {
            Console.WriteLine(a3);
        }
    }
    class Class13
    {
        public static void Main14()
        {
            A a = new A();
        }
    }
}
