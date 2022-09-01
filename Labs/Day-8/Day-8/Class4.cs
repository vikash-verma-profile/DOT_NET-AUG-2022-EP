using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Day_8
{
    /// <summary>
    /// =>
    /// </summary>
    class Class4
    {
        public static void Main()
        {
            List<int> number = new List<int>() { 1, 2, 3, 4 };
            //1*1  2*2 3*3
            foreach (var item in number)
            {
                Console.Write(item + "\t");
            }

            Console.WriteLine();
            var square = number.Select(x => x * x);
            var evenNumbers = number.FindAll(x => (x % 2)==0);
            foreach (var item in square)
            {
                Console.Write(item +"\t");
            }
            Console.WriteLine();
            foreach (var item in evenNumbers)
            {
                Console.Write(item + "\t");
            }
        }
    }
}
