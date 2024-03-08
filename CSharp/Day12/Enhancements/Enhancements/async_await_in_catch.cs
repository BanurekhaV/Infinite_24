using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Enhancements
{
    class async_await_in_catch
    {
        static void Main()
        {
            addAsync();
            Console.Read();
        }
        async static Task addAsync()
        {
            try
            {
                int[] arr = new int[5];
                arr[10] = 15;
            }
            catch(Exception e)
            {
                await ExceptionOccured();
                Console.WriteLine("Handled");
            }
            finally
            {
                await ReleaseResources();
            }
        }

        async static Task ExceptionOccured()
        {
            Thread.Sleep(5000);
            Console.WriteLine("Array is out of Bounds.. Please use the index properly");
        }

        async static Task ReleaseResources()
        {
            Thread.Sleep(2000);
            Console.WriteLine("Resources released...");
        }
             
    }
}
