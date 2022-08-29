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

        //field
        private int roll;
        //property
        public int roll_no
        {
            get
            {
                return roll_no;
            }
            set 
            {   
                roll = value;
            }
        }

        private int _name;

        public int Name { get { return _name; } set { _name = value; } }
        public void Print()
        {
            Console.WriteLine(roll);
        }

    }
    class Class3
    {
        public static void Main4()
        {
            IndexerClass Team = new IndexerClass();
            Team.roll_no = 101;
            Team[0] = "Vikash verma 1";
            Team[1] = "Vikash verma 2";
            Team[2] = "Vikash verma 3";
            Team[3] = "Vikash verma 4";
            Team[4] = "Vikash verma 5";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(Team[i]);
            }
            Team.Print();
        }
    }
}
