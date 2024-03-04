using System;
using System.Collections.Generic;


namespace Dotnet_Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numlist = new List<int>();
            numlist.Add(45);
            numlist.Add(56);
            numlist.Add(10);
            numlist.Add(6);

            numlist.Sort();
            foreach(int x in numlist)
            {
                Console.WriteLine(x);
            }
            Console.Read();
        }
    }
}
