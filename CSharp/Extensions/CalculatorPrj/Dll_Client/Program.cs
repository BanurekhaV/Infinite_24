using System;
using CalculatorPrj;
using Calculator2;

namespace Dll_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClass cc = new CalculatorClass();
            int sum=cc.Add2Nos(15, 10);
            Console.WriteLine(sum);
            Console.WriteLine(cc.Subtract2Nos(15,10));
            //named and optional parameters example

            Console.WriteLine("*************");
            //1. normal way of calling a function with arguments using position
            Console.WriteLine(Multiply(4,5));


            //2. Named arguments- where we supply value to a specific argument
            Console.WriteLine(Multiply(a:5,b:4));
            Console.WriteLine(Multiply(b:4, a:5));

            //3. named arguments cannot follow positional arguments
           // Console.WriteLine(Multiply(b:10,15));

            //4.  positional arguments can follow named arguments
            Console.WriteLine(Multiply(10,b:5));

            //optional parameters example
            Console.WriteLine(Multiply1(5));
            Console.Read();
        }

        //named and optional parameters example
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        //optional parameters example
        static int Multiply1(int a, int b=2)  //default value for an argument
        {
            return a * b;
        }
    }
}
