using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstLibrary;

namespace Dotnet_Day11
{
    class CallLibrary
    {
        public static void Main()
        {
            Class1 c1 = new Class1();
            Console.WriteLine(c1.Welcome());
            Console.WriteLine(c1.Add(5,8));
            Console.Read();
        }
    }
}
