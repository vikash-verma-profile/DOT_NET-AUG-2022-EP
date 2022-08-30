using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    
    /// <summary>
/// generic collections work on the specific type is specified in the program 
/// non-generic collections work on object type
/// </summary>
    class Class4
    {
        public static void Main5()
        {
            List<int> lst = new List<int>();
            lst.Add(100);
            lst.Add(200);
            foreach (var item in lst)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("==================Dictionary==============");
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1,"cs.net");
            dt.Add(2, "vb.net");
            dt.Add(3, "asp.net");
            dt.Add(4, "vb.net");
            foreach (KeyValuePair<int,string> item in dt)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            //
            /*
             *
             */
            Console.WriteLine("==================================Sorted List=================");
            SortedList<string,string> sl = new SortedList<string, string>();
            Employee e = new Employee();
           // sl.Add("101", e);
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> item in sl)
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            /*
            * Stack
            */
            Console.WriteLine("==================================Stack=================");
            Stack<string> st = new Stack<string>();
            st.Push("Cs.net");
            st.Push("vb.net");
            st.Push("asp.net");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }

            /*
           * Queue
           */
            Console.WriteLine("==================================Queue=================");
            Queue<string> q = new Queue<string>();
            q.Enqueue("Cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }
    }
}
