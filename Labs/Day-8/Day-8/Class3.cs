using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;


/// <summary>
/// threading
/// </summary>
namespace Day_8
{
    class Class3
    {
        public static void CallThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);//Miliseconds
                Console.WriteLine(i);
            }
        }
        public static void Main()
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "Main Thread";
            //Console.WriteLine(th.Name);

            ThreadStart sampleThread = new ThreadStart(CallThread);
            Thread childThread = new Thread(sampleThread);
            childThread.Start();
           
        }
    }
}
