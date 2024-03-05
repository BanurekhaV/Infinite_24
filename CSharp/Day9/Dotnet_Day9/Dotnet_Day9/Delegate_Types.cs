using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    delegate void Print(int v);
    class Delegate_Types
    {
        static void Main()
        {
            int i = 100;
            //eg 1 anonymous method calls
            Print p = delegate (int x)
              {
                  x += i;
                  Console.WriteLine("We are inside an anonymous Method {0}", x);
              };
            p(10);  //delegate invoking an anonymous method

            //eg 2 anonymous method calls

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evennos = Array.FindAll(numbers, delegate (int num)
                   {
                       return num % 2 == 0;
                   });
            Console.WriteLine("-------Even Nos.-------");
            foreach(int item in evennos)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("----------Predicate Delegates---------");
            Predicate<string> checkcase = delegate (string s)
               {
                   return s.Equals(s.ToUpper());
               };
            bool result = checkcase("Delegates");
            Console.WriteLine(result);

            //with lambda expressions
            Predicate<string> isupper = s => s.Equals(s.ToUpper());
            bool res = isupper("Delegates");
            Console.WriteLine(res);

            Console.WriteLine("Function Delegates ----------");

            Func<int> getRandomnumber = delegate ()
               {
                   Random r = new Random();
                   return r.Next(1, 100);
               };

            int rnumber = getRandomnumber();
            Console.WriteLine(rnumber);

            //with lambda expression
            Func<int> randnumgen = () => new Random().Next(1, 100);
            int rvalue= randnumgen();
            Console.WriteLine(rvalue);

            Console.WriteLine("Action Delegates ----");
            Action<int> Actiondel = delegate (int s)
            {
                Console.WriteLine(s);
            };

            Actiondel(125);

            //with lambda expression
            Action<int> displaydel = a => Console.WriteLine(a);
            displaydel(200);
            Console.Read();
        }
    }
}
