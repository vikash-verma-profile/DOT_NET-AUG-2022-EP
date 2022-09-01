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
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(5000);//Miliseconds
                    Console.WriteLine(i);
                }
            }
            catch(ThreadAbortException ex)
            {
                Console.WriteLine("Thread abort");
            }
            finally
            {
                Console.WriteLine("Can't catch the thread exception");
            }
           
        }
        public static void Main4()
        {
            //Thread th = Thread.CurrentThread;
            //th.Name = "Main Thread";
            //Console.WriteLine(th.Name);

            ThreadStart sampleThread = new ThreadStart(CallThread);
            Thread childThread = new Thread(sampleThread);
            childThread.Start();
            Thread.Sleep(2000);
            //childThread.Abort();
            childThread.Priority = ThreadPriority.Highest;
        }
    }
}
