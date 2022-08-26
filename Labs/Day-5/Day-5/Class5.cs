using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{

    //base
    class SampleB
    {
        public string b = "vikash";
        public virtual void show()
        {
            Console.WriteLine("Hi i am sample b");
        }

        public SampleB()
        {

        }
        public SampleB(int a, int b)
        {
            Console.WriteLine("a=" + a + "b=" + b);
        }
    }
    //
    class SampleC:SampleB
    {
        int a;
        public string b = "Suresh";

        public override void show()
        {
            base.show();
            Console.WriteLine("I am in sample c");
        }
        public SampleC(int a)
        {
            this.a = a;
            Console.WriteLine(b);
            Console.WriteLine(base.b);

        }

        public void Print()
        {
            Console.WriteLine("Value of a is "+a);
        }
    }
    class Class5
    {
        public static void Main6()
        {
            SampleC sampleC = new SampleC(1);
            sampleC.Print();
            SampleB b = new SampleC(1);
            b.show();

        }
    }
}
