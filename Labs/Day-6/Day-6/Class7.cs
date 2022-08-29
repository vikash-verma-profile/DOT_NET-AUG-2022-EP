using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Extension Methods
    /// </summary>
    /// 

    class Dummy
    {
        public void Show()
        {
            Console.WriteLine("Show");
        }
    }
    static class NewMethodClass
    {
        public static void print(this Dummy dummy)
        {
            Console.WriteLine("Print");
        }
    }
    class Class7
    {
        public static void Main()
        {
            Dummy d = new Dummy();
            d.Show();
            d.print();
        }
    }
}
