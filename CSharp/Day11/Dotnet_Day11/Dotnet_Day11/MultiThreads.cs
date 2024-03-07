using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dotnet_Day11
{
    class MultiThreads
    {
        static void Main()
        {
            Console.WriteLine("Main thread started...");

            //let us create thread objects
            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };
            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };
                         
            t1.Start();
            t2.Start();
            t3.Start();

            //the above association of the thread to the method name can also be 
            //achieved as below
            Thread t0 = new Thread(Greetings);
            Thread t = new Thread(new ThreadStart(Greetings));
            Thread tt = new Thread(delegate () { Greetings(); });
            Thread ttt = new Thread(() => { Greetings(); });
            Thread tttt = new Thread(() => Greetings());

            Console.Read();
        }
        static void Method1()
        {
            Console.WriteLine("Method 1 started " + " "+ Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 1 : no.of times : " + i);
            }
        }
        static void Method2()
        {
            Console.WriteLine("Method 2 started " + " " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : no.of times :{0} ", i);
                if (i == 3)
                {
                    Console.WriteLine("Large Operation started....");
                    Thread.Sleep(10000);
                    Console.WriteLine("Large operation complete...");
                }
            }
        }
        static void Method3()
        {
            Console.WriteLine("Method 3 started " + " " + Thread.CurrentThread.Name);
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 : no.of times : " + i);
            }
        }

        static void Greetings()
        {
            Console.WriteLine("Hello Thread..");
        }
    }
}
