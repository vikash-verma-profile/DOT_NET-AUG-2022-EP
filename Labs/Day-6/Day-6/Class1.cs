using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{


    /// <summary>
    /// ENUMS
    /// </summary>
    /// 
    enum months
    {
        jan=1,
        feb=2,
        march=3
    }
    enum Status
    {
        Inactive,
        Active
    }
    class Class1
    {
        public static void Main2()
        {
            Console.WriteLine((int)months.feb);
            Console.WriteLine((int)Status.Inactive);
            Console.WriteLine(Status.Active);
        }
    }
}
