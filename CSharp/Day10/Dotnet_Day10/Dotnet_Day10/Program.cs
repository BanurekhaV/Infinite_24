using System;


namespace Dotnet_Day10
{
    class Program : IDisposable
    {
        public Program()
        {
            Console.WriteLine("Allocating Resources...");
        }

        public void DoSomeWork()
        {
            Console.WriteLine("Application is using the Resources....");
        }

        static void Main(string[] args)
        {
            using (var dobj = new Program())
            {
                dobj.DoSomeWork();
            } // the end of using block will call the dispose()

            //Program p = new Program();
            //p.DoSomeWork();
            //p.Dispose();  //calling dispose explicitly
            Console.Read();
        }

        public void Dispose()
        {
            Console.WriteLine("Releasing Resources....");
        }
    }
}
