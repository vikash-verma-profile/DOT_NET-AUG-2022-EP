using System;
using System.IO;

namespace Day_8
{
    /// <summary>
    /// reading and writing in a file
    /// </summary>
    /// 
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName+@"\Files\sample.txt";
            //StreamWriter writer = new StreamWriter(projectDirectory);
            //writer.WriteLine("Hi My name is vikash verma");
            //writer.Close();

            //using (StreamWriter writer1 = new StreamWriter(projectDirectory))
            //{
            //    writer1.WriteLine("Hi My name is vikash verma from using keyword");
            //}




            //string[] names = { "Vikash Verma","Suresh Kumar","Raj Kumar" };

            Employee emp = new Employee();
            emp.Id = 1;
            emp.Name = "Sameer";

            
            File.WriteAllText(projectDirectory, "Id:"+emp.Id.ToString()+"Name:"+emp.Name);
            string readText = File.ReadAllText(projectDirectory);
            Console.WriteLine(readText);


        }
    }
}
