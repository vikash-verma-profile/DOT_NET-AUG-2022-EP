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

        public void getdata()
        {

        }
    }
    class Program
    {
        static void Main1(string[] args)
        {
            Person person;
            person.Name = "Vikash Verma";
            person.Weight = 90;
            person.Age = 43;
            person.getdata();

            Console.WriteLine("Details of a person are :");
            Console.WriteLine("Name : "+person.Name);
            Console.WriteLine("Weight : " + person.Weight);
            Console.WriteLine("Age : " + person.Age);
        }
    }
}
