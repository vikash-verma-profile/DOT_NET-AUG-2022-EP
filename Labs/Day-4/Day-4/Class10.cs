using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class Caluclator
    {
        int number;
        public Caluclator(int _number)
        {
            number = _number;
        }
        public static Caluclator operator +(Caluclator c1, Caluclator c2)
        {
            Caluclator c3 = new Caluclator(0);
            c3.number = c1.number + c2.number;
            return c3;
        }
        public void print()
        {
            Console.WriteLine("Number is " + number);
        }
    }
    class Class10
    {
        public static void Main()
        {
            Caluclator c1 = new Caluclator(5);
            Caluclator c2 = new Caluclator(10);
            Caluclator c3 = c1 + c2;
            c3.print();
        }
    }
}
