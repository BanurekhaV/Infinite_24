using System;

using System.Threading;

namespace Dotnet_Day11
{
    class Threads_1
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            Console.WriteLine("Current Executing Thread :" + t.Name);
            Console.WriteLine("Current Executing Thread :" + Thread.CurrentThread.Name);

            Method1();
            Method2();
            Method3();
            
            Console.Read();
        }

        static void Method1()
        {
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine("Method 1 : no.of times : "+ i);
            }
        }
        static void Method2()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 2 : no.of times :{0} ",  i);
                if(i==3)
                {
                    Console.WriteLine("Large Operation started....");
                    Thread.Sleep(10000);
                    Console.WriteLine("Large operation complete...");
                }
            }
        }
        static void Method3()
        {
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("Method 3 : no.of times : " +i);
            }
        }
    }
}
