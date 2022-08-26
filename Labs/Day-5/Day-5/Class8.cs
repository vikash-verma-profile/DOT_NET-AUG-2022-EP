using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    /// <summary>
    /// Exceptional handling
    /// 
    /// try
    ///catch
    ///finally
    ///throw
    /// custom exception handling
    /// </summary>
    class Class8
    {
        public static void Main9()
        {
            try
            {
                int a = 0, b = 5;
               // int c = b / a;
               // Console.WriteLine(c);
            }
            catch(Exception obj)
            {
                Console.WriteLine("some error have occured \n "+ obj.Message);
                Console.WriteLine(obj.StackTrace);
            }
            finally
            {
                Console.WriteLine("Hello i am finally block");
            }
           
        }
    }
}
