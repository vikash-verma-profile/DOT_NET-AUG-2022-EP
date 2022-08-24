using System;
using System.Collections.Generic;
using System.Text;

namespace Day_3
{
    class Class3
    {
        /// <summary>
        /// Find duplicate characters in a string
        /// </summary>
        /// <param name="args"></param>
        static void Main4(string[] args)
        {
            string s = "aabbcddfghh";
            char[] chararray = new char[s.Length];
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
                        index++;
                    }
                }
            }

            foreach (var item in chararray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
