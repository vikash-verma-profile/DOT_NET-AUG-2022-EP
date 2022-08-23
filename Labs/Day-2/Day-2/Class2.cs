using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class2
    {
        public static void Main3()
        {
            //<data-type> [] nameofvariable = new data-type[] 
            int[] values = new int[] {1,2,3,4,5 };

            string[] names = new string[2];

            foreach (int item in values)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=============================");

            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
            Console.WriteLine("===========Names==================");
            for (int i = 0; i < names.Length; i++)
            {
                names[i]=Console.ReadLine();
            }

            foreach (string item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}
