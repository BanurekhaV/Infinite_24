using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day13
{
    class Type_Pattern
    {
        static void PrintUpperCase_IfString(object obj)
        {
            //if obj is a string
            if(obj is string msg)
            {
                Console.WriteLine($"{msg.ToUpper()}");
            }
            else
            {
                Console.WriteLine($"{obj} is not a string");
            }
        }

        static void Main()
        {
            string str = "Hello All";
            int n = 45;
            object o1 = str;
            object o2 = n;

            PrintUpperCase_IfString(o1);
            PrintUpperCase_IfString(o2);
            Console.Read();
        }
    }

    
}
