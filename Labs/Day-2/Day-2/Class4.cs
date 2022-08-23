using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class4
    {
        /// <summary>
        /// Jagged array
        /// </summary>
        public static void Main()
        {
            // data-type[][] nameofarray=new data-type[rows][]
            int n = 4;
            int[][] jagged_array = new int[n][];
            jagged_array[0] = new int[] { 1,2};
            jagged_array[1] = new int[] { 1,2,3,4};
            jagged_array[2] = new int[] { 1,2,3,4,5,6};
            jagged_array[3] = new int[] { 1};

            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int k = 0; k < jagged_array[i].Length; k++)
                {
                    Console.Write(jagged_array[i][k]);
                }
                Console.WriteLine();
            }

        }
    }
}
