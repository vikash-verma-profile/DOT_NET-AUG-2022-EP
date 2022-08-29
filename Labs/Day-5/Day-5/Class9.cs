﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class CustomException:Exception
    {
        public CustomException(string message):base(message)
        {

        }
    }
    class Class9
    {
        public static void Main10()
        {
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (a == 0)
                {
                    throw (new CustomException("Please give valid input"));
                }
                else
                {
                    Console.WriteLine(a);
                }
            }
            catch(CustomException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
