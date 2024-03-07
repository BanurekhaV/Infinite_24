using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dotnet_Day11
{
    class ThreadPoolEg
    {
        static void Main()
        {
            //no pool

            //for(int i=0; i<10;i++)
            //{
            //    Thread thread = new Thread(DoSomething)
            //    {
            //        Name = "Thread " + i
            //    };
            //  thread.Start();

            // with pool
            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(DoSomething));
            }

            Console.Read();
        }

        public static void DoSomething(object o)
        {
            Thread thread = Thread.CurrentThread;
            string msg = $"Background :{thread.IsBackground}," +
                $" Thread Pool : {thread.IsThreadPoolThread}," +
                $"Thread ID : {thread.ManagedThreadId}";

            Console.WriteLine(msg);
        }
    }
       
}

