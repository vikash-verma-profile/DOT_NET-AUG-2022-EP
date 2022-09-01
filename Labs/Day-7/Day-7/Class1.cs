using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Generic delegates
    /// Func
    /// Action
    /// Predicate
    /// </summary>
    class Class1
    {
        delegate double CalculateSimpleInterest(double a, double b, double c);
        static CalculateSimpleInterest obj = getTotalInterest;
        public static void Main()
        {
            double SI;
            //Declare the func delegate
            //<interset as a argument,double acting as return type>
            Func<Interest, double> calcSI = x => (x.P * x.R * x.T) / 100;
            Interest ObjI = new Interest();
            ObjI.P = 120;
            ObjI.R = 2.35;
            ObjI.T = 1;
            SI = calcSI(ObjI);
            Console.WriteLine(SI);

            Action<string> MYAction = y => Console.WriteLine(y);
            MYAction("Hello");

            Predicate<string> checkValue = d => IsValid(d);
            if (checkValue("12"))
            {
                Console.WriteLine("Valid valyue");
            }

            

        }

        static bool IsValid(string s)
        {
            return true;
        }
        static double getTotalInterest(double a, double b, double c)
        {
            return (a * b * c) / 100;
        }
    }

    class Interest
    {
        public double P { get; set; }
        public double T { get; set; }
        public double R { get; set; }
    }
}
