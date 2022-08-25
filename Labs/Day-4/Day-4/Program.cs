using System;
using System.Diagnostics;

namespace Day_4
{
    class Program
    {
        int a;
        public Program()
        {
            //local variable
            int b;
            Console.WriteLine("Hello");
            Debug.Print("new Constructor");
            Debug.Write("write");
        }
        ~Program()
        {
            Debug.Print("Destructor");
        }
        public void print()
        {
            Console.WriteLine("I am a function");
        }
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.print();
        }
    }
}
