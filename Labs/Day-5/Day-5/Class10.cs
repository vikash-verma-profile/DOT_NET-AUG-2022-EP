using System;
using System.Collections.Generic;
using System.Text;

namespace Day_5
{
    class Class10
    {
        public static void Main()
        {
            try {
                //int a = 0, b = 10;
                //Console.WriteLine(b / a);
                int[] ab = new int[1];
                Console.WriteLine(ab[2]);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
