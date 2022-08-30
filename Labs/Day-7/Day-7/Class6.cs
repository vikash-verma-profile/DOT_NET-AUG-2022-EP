using System;
using System.Collections.Generic;
using System.Text;

namespace Day_7
{
    /// <summary>
    /// Grabage Collection
    /// </summary>
    class Class6
    {

        //Object birth
        public Class6()
        {
            //
        }
        ~Class6()
        {

        }
        public static void Main()
        {
            //1.Allocation==>aquire raw heap memory
            //2.Intialization
            Class6 c = new Class6();

            GC.Collect();
           
        }


        //Object death
        /*
         * finalization
         * convert object to raw heap memory
         */

        /*
         * 
         * Deallocation
         */
    }
}
