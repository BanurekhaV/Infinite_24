using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Example2
{
    static class ExtClass
    {
        public static void M4(this Program p)
        {
            Console.WriteLine("Method 4");
        }

        public static void M5(this Program p, string str)
        {
            Console.WriteLine(str);
        }
    }
}
