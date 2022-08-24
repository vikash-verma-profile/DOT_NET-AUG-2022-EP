using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class5
    {
        /// <summary>
        /// parse int
        /// </summary>
        public static void Main()
        {
            int number = int.Parse("23");
            Console.WriteLine(number);
            Console.WriteLine("==================");
            int result;
            bool IsParsed = int.TryParse("asdasd", out result);
            Console.WriteLine(result);
            Console.WriteLine(IsParsed);
        }
    }
}
