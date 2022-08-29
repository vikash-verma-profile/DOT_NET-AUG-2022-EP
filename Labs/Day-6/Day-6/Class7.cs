using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

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

    static class ExtensionClass
    {
        public static void print(this ClassLibrary1.Class1 dummy)
        {
            Console.WriteLine("Print");
            dummy.Show();
        }
    }
    class Class7
    {
        public static void Main()
        {
            Dummy d = new Dummy();
            d.Show();
            d.print();

            ClassLibrary1.Class1 c = new ClassLibrary1.Class1();
            c.Show();
            c.print();
        }
    }
}
