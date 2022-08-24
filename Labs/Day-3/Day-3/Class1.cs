using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class1
    {
        static void Main(string[] args)
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
        }
    }
}
