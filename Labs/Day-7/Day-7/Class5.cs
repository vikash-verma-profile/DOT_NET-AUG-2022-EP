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
        public static void Main6()
        {
            //string a = "AAAA";
            //string expectedPattern = "^[0-9]{5}$";
            //string stringPattern = "^[a-z]&[A-Z]{4}$";
            //Regex r = new Regex(stringPattern);
            //if (r.IsMatch(a.ToString()))
            //{
            //    Console.WriteLine("Valid Input");
            //}
            //else {

            //    Console.WriteLine("Invalid Input");

            //}

            //validate valid mobile number

            Regex r = new Regex(@"^\+?\d{0,2}\-?\d{4,5}\-?\d{5,6}");

            string str = "+91-78271300";
            if (r.IsMatch(str))
            {
                Console.WriteLine("Valid mobile number");
            }
            else
            {
                Console.WriteLine("Invalid Mobile Number");
            }
          
        }
    }
}
