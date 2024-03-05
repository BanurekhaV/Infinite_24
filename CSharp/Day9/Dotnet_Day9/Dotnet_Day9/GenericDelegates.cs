using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_Day9
{
    public delegate T Change<T>(T args);  //generic delegate decl.
    class GenericDelegates
    {
        public static void ChangeType<T>(T[] values, Change<T>cd)
        {
            for(int i=0; i<values.Length;i++)
            {
                values[i] = cd(values[i]); //is equivalent to saying cd(4)
            }
        }
    }

    class Delegates_With_Generic
    {
        static void Main()
        {
            //  int[] val = new int[] { 4, 5, 6 };

            float[] val = new float[] { 4.4f, 5.5f, 6.6f };
            Console.WriteLine("Original Elements");
            foreach (var i in val)
            {
                Console.Write(i + " ");
            }
            GenericDelegates.ChangeType(val, Square);
            Console.WriteLine();
            Console.WriteLine("Changed Elements");
            foreach(var i in val)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static float Square(float x)
        {
            return x * x;
        }
    }
}
