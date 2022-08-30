using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day_7
{
    /// <summary>
    /// Regex
    /// </summary>
    class Class5
    {
        public static void Main()
        {
            string a = "AAAA";
            string expectedPattern = "^[0-9]{5}$";
            string stringPattern = "^[a-z]&[A-Z]{4}$";
            Regex r = new Regex(stringPattern);
            if (r.IsMatch(a.ToString()))
            {
                Console.WriteLine("Valid Input");
            }
            else {

                Console.WriteLine("Invalid Input");

            }
          
        }
    }
}
