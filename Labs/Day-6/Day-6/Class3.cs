using System;
using System.Collections.Generic;
using System.Text;

namespace Day_6
{
    /// <summary>
    /// Indexers
    /// Smart arrays
    /// </summary>
    class IndexerClass
    {
        private string[] names = new string[5];

        public string this[int i]
        {
            get
            {
                return names[i];
            }

            set
            {
                names[i] = value;
            }
        }

    }
    class Class3
    {
        public static void Main()
        {
            IndexerClass Team = new IndexerClass();
            Team[0] = "Vikash verma 1";
            Team[1] = "Vikash verma 2";
            Team[2] = "Vikash verma 3";
            Team[3] = "Vikash verma 4";
            Team[4] = "Vikash verma 5";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Team[i]);
            }

        }
    }
}
