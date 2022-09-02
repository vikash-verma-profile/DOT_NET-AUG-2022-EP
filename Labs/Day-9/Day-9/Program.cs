using System;

namespace Day_9
{
    /// <summary>
    /// C# new features
    /// Tuples
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Tuple<bool, string> s = new Tuple<bool, string>(true,"");
            Console.WriteLine("Please enter some value to validate");
            //Console.WriteLine();
            var result = Validate(Convert.ToInt32(Console.ReadLine()));
            if (result.Item1== true)
            {
                Console.WriteLine(result.Item2);
            }
        }

        //return boolen and a message
        public static Tuple<bool, string> Validate(int a)
        {
            if (a > 5)
            {
                return new Tuple<bool,string>(true, "Input is greater than 5");
            }
            return new Tuple<bool, string>(false, "Input is less than 5");
        }
    }
}
