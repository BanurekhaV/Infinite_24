using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2
{
    class ReadOnlynConstant
    {
        readonly bool flag = true;  //initializing at the time of declaring
        readonly int ronly;  // only declaration

        //private constructor
        internal ReadOnlynConstant()
        {
            Console.WriteLine(flag + " " + ronly);
            flag = false;
            ronly = 100;  //initilaizing the readonly variable in the constructor
            Console.WriteLine("-----------");
            Console.WriteLine(flag + " " + ronly);
        }
    }

    class Trial
    {
        public static void Main()
        {
            ReadOnlynConstant rc = new ReadOnlynConstant();
            Console.WriteLine("Hi");
            Console.Read();
        }
    }
}
