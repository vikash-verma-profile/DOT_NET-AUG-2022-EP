using System;

namespace Day_6
{

    /// <summary>
    /// Structure
    /// 
    /// 
    /// </summary>
    /// 
    struct Person
    {
        public string Name;
        public int Age;
        public int Weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person;
            person.Name = "Vikash Verma";
            person.Weight = 90;
            person.Age = 43;

            Console.WriteLine("Details of a person are :");
            Console.WriteLine("Name : "+person.Name);
            Console.WriteLine("Weight : " + person.Weight);
            Console.WriteLine("Age : " + person.Age);
        }
    }
}
