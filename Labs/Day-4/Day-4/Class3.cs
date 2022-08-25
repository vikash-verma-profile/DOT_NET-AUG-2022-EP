using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// static varriable
    /// static Method
    /// </summary>
    /// 
    class StaticVariable
    {
        //public static int a;

        //1
        static StaticVariable()
        {
            Console.WriteLine("I am a static constructor");
        }

        //2
        public StaticVariable()
        {
            Console.WriteLine("I am a default constructor");
        }


        //public void Sample2()
        //{

        //}
        //public static void Sample()
        //{

        //}
    }
    class Class3
    {
        public static void Main4()
        {
            StaticVariable s = new StaticVariable();
            //StaticVariable.a = 1;

            //StaticVariable.Sample();
            //s.Sample2();
        }
    }
}
