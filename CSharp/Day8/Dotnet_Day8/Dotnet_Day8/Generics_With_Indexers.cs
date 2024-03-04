using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day8
{
    class Generics_With_Indexers<T>
    {
        T[] obj = new T[3];
        int count = 0;

        //adding elements into the generic array object
        public void Add(T item)
        {
            if(count + 1 <4)
            {
                obj[count] = item;
            }
            count++;
        }

        //indexer

        public T this[int index]
        {
            get {return obj[index]; }
            set {obj[index]=value; }
        }
    }

    class CheckGenerics
    {
        static void Main()
        {
            Generics_With_Indexers<int> intobj = new Generics_With_Indexers<int>();
            intobj.Add(1);
            intobj.Add(2);
            intobj.Add(3);

            for(int i=0; i<3; i++)
            {
                Console.WriteLine(intobj[i]);
            }

            intobj[0] = 10;  //this[0]

            Console.WriteLine("**************");

            Generics_with_IndexerOverloading<string> genfloat = new Generics_with_IndexerOverloading<string>();
            genfloat["0"] = "Hi";
            genfloat["1"] = "Hello";
            genfloat["2"] = "Bye";
            Console.WriteLine(genfloat[0] + " " + genfloat[1]+ " " + genfloat[2]);
            Console.Read();
        }
    }

    class Generics_with_IndexerOverloading<T>
    {
         T[] data = new T[3];
       

        //overloaded indexers

        //1. 
        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }

        //2. 

        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        //3.

        public T this[string index]
        {
            get { return data[1]; }
            set { data[1] = value; }
        }
    }
}
