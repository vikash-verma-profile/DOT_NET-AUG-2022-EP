using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// static keyword
    /// class
    /// variables
    /// Method
    /// Constructor
    /// </summary>
    /// 

    /*static class
     * 
     * all members in the class should be static
     * you cannot have any non-static member inside a static class
     */
    static class Sample
    {
        public static int a;

        static Sample()
        {
            Console.WriteLine("I am a static constructor");
        }

        public static void Print()
        {
            Console.WriteLine("Value of a "+a);
        }
    }
    class Class2
    {
        public static void Main3()
        {
            Console.WriteLine("Value of a in main :"+Sample.a);
            Sample.Print();
        }
    }
}
