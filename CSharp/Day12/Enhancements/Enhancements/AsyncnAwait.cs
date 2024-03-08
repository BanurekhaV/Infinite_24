using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class AsyncnAwait
    {
        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                for(int i=0; i<50; i++)
                {
                    Console.WriteLine("Task 1 Executing.. no of times :{0}",i );

                    Task.Delay(100).Wait();
                }
            });
        }

        public static void NormalMethod()
        {
            for (int i = 0; i < 25; i++)
            {
                Console.WriteLine("Normal Method Executing.. no.of Times : {0}",i);

                Task.Delay(100).Wait();
            }

        }

        static void Main()
        {
            Task1();
            NormalMethod();
            Console.Read();
        }
    }
}
