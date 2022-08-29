using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{

    public class MySampleClass
    {
        //Instance Method
        public string sampleMethod(int a)
        {
            if (a > 0)
            {
                return ("Postive");
            }
            if (a < 0)
            {
                return ("Negative");
            }

            return ("Zero");
        }

        public static string StaticMethod(int a)
        {
            if (a > 0)
            {
                return ("+");
            }
            if (a < 0)
            {
                return ("-");
            }

            return ("0");
        }
    }
    class Class5
    {
        public delegate string SampleDelegate(int a);
        public static void Main6()
        {
            MySampleClass Mys = new MySampleClass();

            //Intance Methiod
            SampleDelegate d1 = new SampleDelegate(Mys.sampleMethod);
            SampleDelegate d2 = new SampleDelegate(MySampleClass.StaticMethod);

            Console.WriteLine("Instance Method ::" + d1(5) + "========== Static ::"+ d2(5)); //1.
            Console.WriteLine("Instance Method ::" + d1(-3) + "========== Static ::" + d2(-3)); //2.
            Console.WriteLine("Instance Method ::" + d1(0) + "========== Static ::" + d2(0)); //3.
        }
    }
}
