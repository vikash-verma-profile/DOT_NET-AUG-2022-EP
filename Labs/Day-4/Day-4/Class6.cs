using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// abstract keyword
    /// </summary>
    /// 

    /*An abstract class is the one that cannot be instantiated
     * you can make it a base class and use it
     * It can have both abstarct and non-abstract members
     * an abstract class cannot sealed
     */
    abstract class Wholesellar
    {
        //non-abstract member
        public int a;
        abstract public void Discount();
    }
    class Reatailer: Wholesellar
    {
        public override void Discount()
        {
            Console.WriteLine("I am giving you 10% discount");
        }
        public void Show()
        {
            Console.WriteLine("The value of a "+a);
        }
    }
    class Class6
    {
        //Customer
        public static void Main7()
        {
            Reatailer ob = new Reatailer();
            ob.Discount();
        }
    }
}
