using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class Sample
    {

    }
    class Sample1 : Sample { }
    class Class1
    {
        /// <summary>
        /// is vs as
        /// is==>realted to if/else or comparsion
        /// as==>related to type casting or conversion
        /// </summary>
        /// 
        public static void Main2()
        {
            Sample obj = new Sample();
            Sample1 obj1 = new Sample1();

            Console.WriteLine(obj is Sample);
            Console.WriteLine(obj1 is Object);
            Console.WriteLine(obj is Sample1);

            //as operator
            Console.WriteLine("==================================");
            object[] o = new object[5];
            o[0] = new Sample();
            o[1] = new Sample1();
            o[2] = "Hello";
            o[3] = 7878.0;
            o[4] = null;


            for (int i = 0; i < o.Length; i++)
            {
                string str = o[i] as string;

                if (str != null)
                {
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine("It is not a string");
                }
            }
        }
    }
}
