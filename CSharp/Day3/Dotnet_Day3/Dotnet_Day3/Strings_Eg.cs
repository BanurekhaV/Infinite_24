using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day3
{
    class Strings_Eg
    {
        public static void String_Ops()
        {
            string s = "Hello";         
            Console.WriteLine("First Time s is :{0} and Value is :{1}", s.GetHashCode(),s);
            s = "Hello World";
            Console.WriteLine("Second Time s is :{0} and Value is :{1}", s.GetHashCode(),s);

            string s1 = "CSharp";
            Console.WriteLine("s1 hash is :{0} and Value is :{1}", s1.GetHashCode(), s1);

            string s2 = s1;
            Console.WriteLine("s2 hash is :is {0} and Value is {1}", s2.GetHashCode(),s2);

            string s3 = "Hello"; // both the reference as well as data are taken from
            //the pool. as there is already an entry made in the pool

            Console.WriteLine("s3 reference is same as s{0} and Value {1}", s3.GetHashCode(),s3);

            Console.WriteLine("------Values of all String Objects------");

            Console.WriteLine(s + " " + s1 + " " + s2 + " " + s3);

            char[] carr = new char[] { 'w', 'e', 'l', 'c', 'o', 'm', 'e' };
            string mystring = new string(carr); //will not consider string pool
                                                // but will allocate seperate memory like other objects
                                                //string builder class
            StringBuilder sb = new StringBuilder("Hello");
            Console.WriteLine("----Original hash of string builder-------");
            Console.WriteLine("Sbs hash code is {0} and the value is {1}", sb.GetHashCode(), sb);
            sb.Append(", C# String Builders");
            Console.WriteLine("----String Builder after changes----");
            Console.WriteLine("Sbs hash code is {0} and the value is {1}", sb.GetHashCode(), sb);
        }
    }
}
