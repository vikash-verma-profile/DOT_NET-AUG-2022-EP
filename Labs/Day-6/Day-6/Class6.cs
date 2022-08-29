using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Partial types
    /// </summary>
    /// 
    public partial class Employee
    {
        int a;
        public void Dowork()
        {
            Console.WriteLine("Dowork");
        }
        public void sum()
        {
            Console.WriteLine("I am empty sum");
        }
    }
    public partial class Employee
    {
        //int a;
        public void DoLunch()
        {
            Console.WriteLine("DoLunch");
        }
        public void sum(int a)
        {
            Console.WriteLine("I am  sum with a="+a);
        }
    }
    class Class6
    {

        public static void Main7()
        {
            Employee e = new Employee();
            e.DoLunch();
            e.Dowork();
            e.sum();
            e.sum(0);
        }
    }
}
