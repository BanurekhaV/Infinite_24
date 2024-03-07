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
            Console.Read();
        }
    }
}
