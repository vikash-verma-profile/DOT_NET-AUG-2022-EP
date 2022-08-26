using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{

    //properties

    class Myclass
    {
        //hidding
        private int _x;

        public int x { 
            get { return _x; } 
            set { _x = value; } 
        }

        //public void SetX(int i)
        //{
        //    x = i;
        //}

        //public int GetX()
        //{
        //    return x;
        //}

        public void show()
        {
            Console.WriteLine(_x);
        }
    }
    class Class7
    {
        public static void Main8()
        {
            Myclass myclass = new Myclass();
            //myclass.SetX(10);
            //int x = myclass.GetX();
            myclass.x = 1;
            Console.WriteLine(myclass.x);
            myclass.show();
        }
    }
}
