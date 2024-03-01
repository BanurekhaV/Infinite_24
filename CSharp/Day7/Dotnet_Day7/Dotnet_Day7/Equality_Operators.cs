using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day7
{
    class Equality_Operators
    {
        static void Main()
        {
            //Value type 
            int i = 10, j = 10;
            Console.WriteLine(i==j);
            Console.WriteLine(i.Equals(j));

            Console.WriteLine("**********");
            //reference type
            string str1 = "Hello";
            string str2 = "Hello";
            string str3 = "hello";
            Console.WriteLine(str1==str2);  //true
            Console.WriteLine(str1==str3);  //false

            Console.WriteLine(str1.Equals(str2)); //true
            Console.WriteLine(str1.Equals(str3)); //false

            Console.WriteLine("-----------");
            //object obj1="Hello";
            object obj1 = new StringBuilder("Hello");
            object obj2 = "Hello";

            Console.WriteLine(obj1==obj2); //true  , false
            Console.WriteLine(obj1.Equals(obj2)); //true, false

            Console.WriteLine("-----CompareTo-----");

            int a = 5;
            int b = 7;
            int c = 5;

            Console.WriteLine(a.CompareTo(b)); 
            Console.WriteLine(b.CompareTo(a));
            Console.WriteLine(c.CompareTo(a));

            Console.WriteLine("------ReferenceEquals------");
            StringBuilder sb1 = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            Console.WriteLine(object.ReferenceEquals(sb1,sb2));

            sb1 = sb2;

            Console.WriteLine("Post assignment " + object.ReferenceEquals(sb1, sb2));


            Console.WriteLine("------with strings -------");

            string s1 = "b";
            string s2 = "b";

            Console.WriteLine(object.ReferenceEquals(s1,s2));

            s1 = s2;

            Console.WriteLine("Post assignment " + object.ReferenceEquals(s1, s2));
            Console.Read();
        }
    }
}
