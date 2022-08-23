using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    /// <summary>
    /// ref vs out
    /// </summary>
    class Class6
    {
        public static void Main7()
        {
            int result=0;
            int outresult=1;
            SumRef(1,2, ref result);
            Console.WriteLine("Sum of two numbers with ref keyword is "+result);
            SumOut(1, 2, out outresult);
            Console.WriteLine("Sum of two numbers with out keyword is " + outresult);
        }
        static void SumRef(int a,int b,ref int result)
        {
            int x = result;
            result = a + b;
        }
        static void SumOut(int a, int b, out int result)
        {
            //int x = result;
            result = a + b;
        }

        /*we should assign some value to out parameter before leaving from a method 
         * but in ref its not the same.
         * 
         * 
         * we have to assign some value before passing a ref parameter inside a function that is not 
         * the case in out parameter
         */
    }
}
