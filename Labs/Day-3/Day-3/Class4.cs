using System;
using System.Collections.Generic;
using System.Text;


namespace Day_3
{
    class Class4
    {
        /// <summary>
        /// Check maximum  characters in a string
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            string s = "aaabbcddfghh";
            char[] chararray = new char[s.Length];
            int[] countchararray = new int[s.Length];
            int index = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int counter = 0;
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    //string sk = new String(chararray);
                    //chararray[index] = s[i];
                    if (!new String(chararray).Contains(s[i]))
                    {
                        chararray[index] = s[i];
                        countchararray[index] = counter;
                        index++;
                    }
                }
            }
            int max=countchararray[0];
            int maxindex = 0;
            for (int i = 0; i < countchararray.Length; i++)
            {
                if (max < countchararray[i])
                {
                    max = countchararray[i];
                    maxindex = i;
                }
            }
            Console.WriteLine(chararray[maxindex]+":"+countchararray[maxindex]);
        }
    }
}
