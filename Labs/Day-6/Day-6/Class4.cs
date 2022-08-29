using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Delegates
    /// </summary>
    /// 
    //<delegate> <retun-type><nameof functIOn>()
    class Class4
    {

        //declartion of a delegate
        public delegate void addNum(int a, int b);

        public void sum(int a,int b)
        {
            Console.WriteLine("Sum of two numbers are :"+(a+b));
        }
        public static void Main5()
        {
            Class4 class4 = new Class4();
            //Linking
            addNum delObj = new addNum(class4.sum);

            //calling or invoking
            delObj(100, 200);
            delObj.Invoke(2,3);
        }
    }
}
