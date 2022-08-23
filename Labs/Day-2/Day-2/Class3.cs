using System;
using System.Collections.Generic;
using System.Text;

namespace Day_2
{
    class Class3
    {
        public static void Main()
        {
            int[,] matrix = new int[2,2];

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write("enter the value of matrix[" + row + "," + col + "]=");
                    matrix[row,col]= Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write(matrix[row, col]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}
