using System;

namespace Day_2
{
    class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("======================for loop========");
            //for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("======================while loop========");
            //while loop  entry controlled loop
            int counter = 0;
            while (1!=1)
            {
                Console.WriteLine(counter);
                counter++;
            }
            Console.WriteLine("======================do while loop========");
            //do while exit controlled loop
            counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (1 != 1);


            //foreach (var item in collection)
            //{

            //}
        }
    }
}
