using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day8
{
    //all generics
    class Generics_2<T> 
    {
        T genericMember;

        public Generics_2(T val)
        {
            genericMember = val;
        }

        public T genericMethod(T genericArg)
        {
            Console.WriteLine("Parameter type :{0}, and the Value is :{1}", typeof(T).ToString(), genericArg);
            Console.WriteLine("Return Type {0}, and the Values is {1}", typeof(T).ToString(), genericMember);
            return genericMember;
        }
    }

    class TestGenerics
    {    
        static void Main()
        {
            Generics_2<int> intgen = new Generics_2<int>(10);

            int retval = intgen.genericMethod(100);
            Console.WriteLine(retval + " return value");

            Generics_2<string> strgen = new Generics_2<string>("Constructor Data");

            string res = strgen.genericMethod("String Data of the Method");
            Console.WriteLine();
            Console.WriteLine(res + " return value");

            Console.WriteLine("----- Another Example ------");
            bool isequal = Calculator<string>.Checkequals("aaa","aaa");
            Console.WriteLine(isequal);
            Console.Read();

        }
    }

    class Calculator<T>
    {
        public static bool Checkequals(T v1, T v2)
        {
            return v1.Equals(v2);
        }
    }
}
