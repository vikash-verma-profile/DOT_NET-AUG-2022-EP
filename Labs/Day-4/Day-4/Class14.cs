using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4
{
    class person
    {
        public string Name;

        public person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return "Hello My name is "+Name; 
        }
        ~person()
        {
            Name = string.Empty;
        }
    }
    class Class14
    {

        public static void Main()
        {
            person[] people = new person[2];
            for (int i = 0; i < people.Length; i++)
            {
                people[i] = new person(Console.ReadLine());
            }

            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine(people[i].ToString());
            }
        }
    }
}
