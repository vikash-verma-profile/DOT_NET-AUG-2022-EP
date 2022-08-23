using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    /// <summary>
    /// Var vs Dynamic keyword
    /// </summary>
    class Class5
    {
        public static void Main6()
        {
            //var i = 1.6767;
            ////i = "vikash";
            //Type type = i.GetType();
            //Console.WriteLine(i);
            //Console.WriteLine(type);

            Type type;
            dynamic i = 1.6767;
            type = i.GetType();
            Console.WriteLine(i);
            Console.WriteLine(type);
            i = "vikash";
            type = i.GetType();
            Console.WriteLine(i);
            Console.WriteLine(type);
        }
    }
}
