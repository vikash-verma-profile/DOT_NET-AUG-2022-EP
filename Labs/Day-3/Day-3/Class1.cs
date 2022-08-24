using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class1
    {
        /// <summary>
        /// String vs StringBuilder
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {

            String s = "Vikash Verma";

            s = String.Concat("Hello ", s);
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.WriteLine(s[i]);
            //}
            int indexvalue = s.IndexOf('V');
            Console.WriteLine(indexvalue);
            s=s.Replace("Vikash","Raj");
            s = s.ToLower();
            Console.WriteLine(s);
            s = s.ToUpper();
            Console.WriteLine(s);

            string palindrome = "CHAR";
            char []revr = palindrome.ToCharArray();
            Array.Reverse(revr);
            string rev = new String(revr);

            Console.WriteLine((rev == palindrome) ? "Palidrome" : "Not a Palndrome");

            string k = "Vikash";
            k = "car";

            Console.WriteLine("=====================");
            StringBuilder obj = new StringBuilder();
            StringBuilder obj1 = new StringBuilder("Vikash Verma");
            obj.Append("Vikash");
            obj.Append("Raj");
            obj1.Clear();
            obj1.Append("Kumar");
            Console.WriteLine(obj1);

        }
    }
}
