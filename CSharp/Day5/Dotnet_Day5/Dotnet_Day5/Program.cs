using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day5
{
    class Program
    {
        //readonly
        public readonly int myvariable1;  //just declaration
        public readonly int myvariable2 = 10; //decl and initialization

        int x;  //non-static member
        static int y = 111; // static member (class level)
        const float PI=3.14f; //constant variable (class level)

        //constructor to initialize the readonly variables
        internal Program(int a, int b)
        {
            myvariable1 = a;
            myvariable2 = b;
            Console.WriteLine("Value of Myvariable1 :{0}, and Myvariable 2 :{1}", myvariable1,myvariable2);
            y = 222;
        }

        static void Main(string[] args)
        {
           Program program = new Program(100, 200);

            Program program2 = new Program(500, 1000);

            Console.Read();
        }

    }
}
