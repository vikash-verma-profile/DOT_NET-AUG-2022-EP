using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1
{
    class Class4
    {
        /// <summary>
        /// Implicit Type Casting
        /// </summary>
        public static void Main4()
        {
            //int num = 100;
            //Type type = num.GetType();
            //double numDouble = num;
            //Type typeDouble = numDouble.GetType();
            //Console.WriteLine("num="+num);
            //Console.WriteLine("num type=" + type);
            //Console.WriteLine("numDouble=" + numDouble);
            //Console.WriteLine("numDouble type=" + typeDouble);



            /// <summary>
            /// Explicit Type Casting
            /// </summary>
            /// 
            double numDouble = 100.23;
            Type typeDouble = numDouble.GetType();
            int num = (int)numDouble;
            Type type = num.GetType();
            Console.WriteLine("num=" + num);
            Console.WriteLine("num type=" + type);
            Console.WriteLine("numDouble=" + numDouble);
            Console.WriteLine("numDouble type=" + typeDouble);
        }
    }
}
