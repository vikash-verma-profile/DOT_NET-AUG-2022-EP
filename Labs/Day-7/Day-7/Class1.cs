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
        public static void Main2()
        {
            double SI;
            //Declare the func delegate
           // Func<>
        }
        static double getTotalInterest(double a, double b, double c)
        {
            return (a * b * c) / 100;
        }
    }
}
