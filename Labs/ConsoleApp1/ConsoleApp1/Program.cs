using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public Program()
        {
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
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program p = new Program();
            p.print();
        }
    }
}
