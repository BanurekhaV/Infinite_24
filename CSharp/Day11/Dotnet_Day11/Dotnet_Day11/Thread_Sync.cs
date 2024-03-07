using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Dotnet_Day11
{
    class ThreadLocks
    {
        public static object tloc = new object();
        public static void LockFunction()
        {
            lock(tloc)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                for(int i=0;i<10;i++)
                {
                    Thread.Sleep(new Random().Next(5));
                    Console.WriteLine("The Value of i : {0}", i);
                }
                
            }
        }
    }
    class Thread_Sync
    {
        static void Main()
        {
            //Thread t1 = new Thread(Function1);
            //t1.Start();

            //Thread t2 = new Thread(Function2);
            //t2.Start();

            //t1.Join();
            //t2.Join();

            Thread td1 = new Thread(new ThreadStart(ThreadLocks.LockFunction));
            td1.Name = "First Thread";
            td1.Start();

            Thread td2 = new Thread(new ThreadStart(ThreadLocks.LockFunction));
            td2.Name = "Second Thread";
            td2.Start();
            
            Console.Read();
        }

        public static void Function1(object obj1)
        {
            Console.WriteLine("This is Object one..");
        }

        public static void Function2(object obj2)
        {
            Console.WriteLine("Object 2");
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Function 2 : no.of times :{0} ", i);
                if (i == 3)
                {
                    Console.WriteLine("Large Operation started....");
                    Thread.Sleep(10000);
                    Console.WriteLine("Large operation complete...");
                }
            }
        }
    }
}
