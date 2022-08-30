using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Day_7
{
    class Class3
    {
        public static void Main()
        {
            Hashtable ht = new Hashtable();
            ht.Add("1", "Vikash Vema 1");
            ht.Add("2", "Vikash Vema 2");
            ht.Add("3", "Vikash Vema 3");
            ht.Add("4", "Vikash Vema 4");
            ht.Add("5", "Vikash Vema 5");

            //DictionaryEntry is a class whose object represents the data in a combination of key and value
            //pairs
            //var hash =ht.Keys.Cast<string>().OrderBy(x=>x);
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+"===>"+item.Value);
            }

            //
            /*
             * Combination of arraylist and hashtable
             */
            Console.WriteLine("==================================Sorted List=================");
            SortedList sl = new SortedList();
            Employee e = new Employee();
            sl.Add("101", e);
            sl.Add("cs","cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry item in sl )
            {
                Console.WriteLine(item.Key + "===>" + item.Value);
            }

            /*
            * Stack
            */
            Console.WriteLine("==================================Stack=================");
            Stack st = new Stack();
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
            Queue q= new Queue();
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
