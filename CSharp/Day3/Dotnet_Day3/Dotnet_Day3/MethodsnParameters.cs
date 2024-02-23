using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day3
{
    class MethodsnParameters
    {
        public void CallByValue(int n)  //called function
        {
            n = 100;
            Console.WriteLine($"The Value of n is : {n}"); //string interpolation
        }

        public void CallByRef(ref int n)
        {
            n = 100;
            Console.WriteLine($"The Value of n is : {n}");
        }

        public int Calculate_Function(int num1, int num2, out int diff, out int product, out int div)
        {
            diff = num1 - num2;
            product = num1 * num2;
            div = num1 / num2;
            return num1 + num2;
        }

        //params array example 1:
        public int AddElements(params int[] arr)
        {
            int sum = 0;
            foreach(int n in arr)
            {
                sum += n;
            }
            return sum;
        }

        public void Params_method2(params int[] number)
        {
            Console.WriteLine("There are {0} number of elements in the Array", number.Length);
            foreach(int i in number)
            {
                Console.WriteLine(i);
            }
        }

        public void Params_3(int i, float f, params double[] d)
        {
            Console.WriteLine("{0},{1}",i,f);

            foreach(double dbl in d)
            {
                Console.WriteLine(dbl);
            }
        }
    }
}
