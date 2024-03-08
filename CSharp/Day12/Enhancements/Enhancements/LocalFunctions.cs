using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enhancements
{
    class LocalFunctions
    {
        public static void Main()
        {
            int a = 10, b = 5;
            int total = Sum(a, b);
            int difference = Subtract(a, b);
            Console.WriteLine($"The Sum of {a} and {b} is {total}");
            Console.WriteLine($"The Difference of {a}, and {b} is {difference}");

            //local function
            int Sum(int p, int q)
            {
                a = 20;
                return p + q;
            }

            int Subtract(int x, int y)
            {
                return x - y;
            }

            Console.WriteLine(Sum(10,8));
            Console.Read();
        }
    }
}
