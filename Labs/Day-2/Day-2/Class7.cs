using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    /// <summary>
    /// Boxing vs UnBoxing
    /// Equals vs ==
    /// </summary>
    /// 
    //class student
    //{
    //    public int name { get; set; }
    //}
    class Class7
    {
        public static void Main()
        {
            //boxing value type to refrence type
            int i = 1;
            int j = 0;
            object s = i;
            Console.WriteLine(s);

            //student s2 = new student();
            //s2.name = 1;

            //unboxing refrence type to value type
            object k = 1;
            int s1 = (int)k;
            Console.WriteLine(s1);

        }
    }
}
