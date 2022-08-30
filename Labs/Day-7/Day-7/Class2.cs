using System;
using System.Collections;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Collections
    /// Adding and inseting items to a collection
    /// 
    /// Non-generic   generic
    /// </summary>
    class Class2
    {
        public static void Main()
        {
            ArrayList al = new ArrayList();
            string str = "Vikash Vermna";
            int x = 7;
            DateTime d = DateTime.Now;

            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}
