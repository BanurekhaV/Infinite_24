using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    delegate int Arithmetic(int x, int y);
    class Delegate_As_Argument
    {
        public static void Main()
        {
            DoArithmetic(10, 2, Multiply); 
            DoArithmetic(10, 2, Divide);
            Console.Read();           
        }

        static void DoArithmetic(int x, int y, Arithmetic adel)
        {
            int z = adel(x, y); //calling the delegate with 2 parameters
            Console.WriteLine(z);
        }

        static int Multiply(int x, int y)
        {
            return x * y;
        }

        static int Divide(int x, int y)
        {
            return x / y;
        }
    }
}
