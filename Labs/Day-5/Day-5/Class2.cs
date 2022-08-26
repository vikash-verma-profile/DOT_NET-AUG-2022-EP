using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// equals vs ==
    /// </summary>
    class Class2
    {
        public static void Main3()
        {
            //string name = "Vikash";
            //string myname = name;
            //Console.WriteLine(name == myname);//1.
            //Console.WriteLine(name.Equals(myname));//2.

            //object name = "Vikash";
            //char[] values = { 'V', 'i','k','a','s','h' };
            //object myname = new string(values);
            //Console.WriteLine(name==myname); //1.
            //Console.WriteLine(myname.Equals(name));//2.

            /*equals compares the contents of the object
             * == compates the reference identity
             * equal function can fail in case of null values
             * 
             * 
             */

            string name = "Vikash";
            string myname = null;
            Console.WriteLine(name==myname);
            Console.WriteLine(myname.Equals(name));
        }
    }
}
