using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day8
{
    //generic class 

    class GenericClass<T>
    {
        //generic  data member
        T data;
        string Gname;
        //generic property
        public T _Data
        {
            get { return this.data; }
            set { this.data = value; }
        }

        public string _Gname
        {
            get { return Gname; }
            set { Gname = value; }
        }

        //generic method
        public void Display<T>(string msg, T arg)
        {
            Console.WriteLine("{0} : {1}", msg, arg);
        }
    }
    class Generics_1
    {
        public static void Main()
        {
            GenericClass<int> genc = new GenericClass<int>();
            genc._Data = 111;
            genc._Gname = "Infinite";
            Console.WriteLine(genc._Data + " "+ genc._Gname);
            genc.Display<string>("It is a numbered string", "it is 5");
            Console.WriteLine("==============");

            GenericClass<string> gencstr = new GenericClass<string>();
            gencstr._Data = "66";
            Console.WriteLine(gencstr._Data);
            gencstr.Display<float>("It is a Float", 34.5f);
            Console.Read();


        }
    }
}
