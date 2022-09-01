using System;
using System.IO;

namespace Day_8
{
    /// <summary>
    /// reading and writing in a file
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+@"\Files\sample.txt";
            //StreamWriter writer = new StreamWriter(projectDirectory);
            //writer.WriteLine("Hi My name is vikash verma");
            //writer.Close();

            using (StreamWriter writer1 = new StreamWriter(projectDirectory))
            {
                writer1.WriteLine("Hi My name is vikash verma from using keyword");
            }

            string readText = File.ReadAllText(projectDirectory);
            Console.WriteLine(readText);
        }
    }
}
