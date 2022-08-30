using System;

namespace Day_7
{
    /// <summary>
    /// Types of delegates
    /// </summary>
    /// 
    /*
     * 
     * Single Delegate
     * Multi Cast Delegate
     * Generic Delegate
     *  1.Func
     *  2.Action
     *  3.Predicate
     */

    
    class Program
    {
        delegate double CalculateSimpleInterest(double a,double b,double c);
        static CalculateSimpleInterest obj = getTotalInterest;

        static double getTotalInterest(double a, double b, double c)
        {
            return (a * b * c) / 100;
        }

        static double getInterestRatePerYear(double SI,double p,double t)
        {
            return (SI * 100)/(p * t);
        }

        static double getIntersetTimeSpan(double SI, double p, double r)
        {
            return (SI * 100) / (p * r);
        }
        static void Main(string[] args)
        {
            double SI;

            SI = obj.Invoke(120,1,2.35);
            obj = obj + new CalculateSimpleInterest(getInterestRatePerYear);
            double Rate = obj.Invoke(SI,120,1);
            Console.WriteLine("Rate"+Rate);
            obj += new CalculateSimpleInterest(getIntersetTimeSpan);
            double timeSpan = obj.Invoke(SI,120, 2.35);
            Console.WriteLine(timeSpan);

        }
    }
}
