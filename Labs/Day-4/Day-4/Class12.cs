using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    /// <summary>
    /// Overriding
    /// </summary>
    /// 
    class SammpleA
    {
        //old virtual for your CLR
        public virtual void show()
        {
            Console.WriteLine("I am show from Base Class");
        }
        public void Print()
        {
            Console.WriteLine("I am print from Base Class");
        }
    }
    class SampleB:SammpleA
    {
        //new Defination for Show method
        public override void show()
        {
            Console.WriteLine("I am show from Derived Class");
        }
        public void Print()
        {
            Console.WriteLine("I am print from Derived Class");
        }
    }
    class Class12
    {
        public static void Main13()
        {
            SampleB b = new SampleB();
            b.show();//1.Derived class
            SammpleA a = new SammpleA();
            a.show();//2.Base class

            SammpleA a1 = new SampleB();
            a1.show();//base class ...Print derived class
        }
    }
}
